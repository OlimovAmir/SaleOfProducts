using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Employee : Person
    {
        public string Role { get; set; }
        public int PositionId { get; set; } // Идентификатор должности
        public Position Position { get; set; } // Ссылка на должность
        public DateTime? HireDate { get; set; } // Дата принятия на работу (может быть пустой)
        public DateTime? TerminationDate { get; set; } // Дата увольнения (может быть пустой)
        public bool IsHired { get; set; } // Флаг указывающий, принят ли на работу (true - принят, false - уволен)

        // Конструктор класса
        public Employee(string name, string surName, string role, int positionId, DateTime? hireDate, DateTime? terminationDate, bool isHired)
        {
            Name = name;
            SurName = surName;
            Role = role;
            PositionId = positionId;
            HireDate = hireDate;
            TerminationDate = terminationDate;
            IsHired = isHired;
        }


        public Employee() { }


    }
}
