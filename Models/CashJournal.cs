namespace SaleOfProducts.Models
{
    public class CashJournal
    {
        // Коллекция для хранения записей о поступлении денежных средств
        public List<CashIncome> IncomeRecords { get; set; }

        // Конструктор
        public CashJournal()
        {
            IncomeRecords = new List<CashIncome>();
        }

        // Метод для добавления записи о поступлении денежных средств
        public void AddIncomeRecord(double amount, string description, string source)
        {
            CashIncome income = new CashIncome(amount, description, source);
            IncomeRecords.Add(income);
        }

        // Метод для вывода всех записей о поступлении денежных средств
        public void DisplayIncomeRecords()
        {
            Console.WriteLine("Cash Income Records:");
            foreach (var record in IncomeRecords)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}

