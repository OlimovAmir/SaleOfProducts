using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Employee : Person
    {
        public string Role { get; set; }

        public override void DoWork()
        {
            base.DoWork();

            Console.WriteLine("I am done " + GetType().Name + " from overwriten method");
        }
    }
}
