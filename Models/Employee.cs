using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Employee : Person
    {
        
        public Guid PositionId { get; set; } // Идентификатор должности
        public Position Position { get; set; } // Ссылка на должность
        public DateTime? HireDate { get; set; } // Дата принятия на работу (может быть пустой)
        public DateTime? TerminationDate { get; set; } // Дата увольнения (может быть пустой)
        public bool IsHired { get; set; } // Флаг указывающий, принят ли на работу (true - принят, false - уволен)

        // Конструктор класса
        public Employee(string name, string surName, Guid positionId, DateTime? hireDate, DateTime? terminationDate, bool isHired)
        {
            Name = name;
            SurName = surName;
            
            PositionId = positionId;
            HireDate = hireDate;
            TerminationDate = terminationDate;
            IsHired = isHired;
        }


        public Employee() { }

        public override string ToString()
        {
            return $"{Name} {SurName} {HireDate} {TerminationDate} {IsHired}";
        }

    }
}
