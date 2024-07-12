# Use the official ASP.NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SaleOfProducts.csproj", "./"]
RUN dotnet restore "./SaleOfProducts.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SaleOfProducts.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SaleOfProducts.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourProject.dll"]