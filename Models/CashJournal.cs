namespace SaleOfProducts.Models
{
    public class CashJournal
    {
        // Коллекции для хранения записей о приходах и расходах денежных средств
        public List<CashIncome> IncomeRecords { get; set; }
        public List<CashExpense> ExpenseRecords { get; set; }

        // Конструктор
        public CashJournal()
        {
            IncomeRecords = new List<CashIncome>();
            ExpenseRecords = new List<CashExpense>();
        }

        // Метод для добавления записи о приходе денежных средств
        public void AddIncomeRecord(double amount, string description, string source)
        {
            CashIncome income = new CashIncome(amount, description, source);
            IncomeRecords.Add(income);
        }

        // Метод для добавления записи о расходе денежных средств
        public void AddExpenseRecord(double amount, string description, string destination)
        {
            CashExpense expense = new CashExpense(amount, description);
            ExpenseRecords.Add(expense);
        }

        // Метод для вывода всех записей о приходах денежных средств
        public void DisplayIncomeRecords()
        {
            Console.WriteLine("Cash Income Records:");
            foreach (var record in IncomeRecords)
            {
                Console.WriteLine(record.ToString());
            }
        }

        // Метод для вывода всех записей о расходах денежных средств
        public void DisplayExpenseRecords()
        {
            Console.WriteLine("Cash Expense Records:");
            foreach (var record in ExpenseRecords)
            {
                Console.WriteLine(record.ToString());
            }
        }

        // Метод для вывода общего баланса (разницы между приходами и расходами)
        public void DisplayBalance()
        {
            double totalIncome = IncomeRecords.Sum(record => record.Amount);
            double totalExpense = ExpenseRecords.Sum(record => record.Amount);
            double balance = totalIncome - totalExpense;

            Console.WriteLine($"Total Income: {totalIncome}");
            Console.WriteLine($"Total Expense: {totalExpense}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}


