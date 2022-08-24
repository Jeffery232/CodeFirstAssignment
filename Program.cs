using System.Data.Entity;

namespace CodeFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (var db = new CompanyContext())
                {
                   Company sterling = new Company();
                    sterling.CompanyId = 002; 
                    sterling.CompanyName = "SterlingBank";
                    sterling.CompanyAddress = "2 Sterling House Marina Lagos";
                    sterling.URL = "www.sterlingbank.com";
                    sterling.ProductType = ProductType.Service;
                 // sterling.Products = new List<Product>();  
                   db.Company.Add(sterling);
                    db.SaveChanges();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

           Console.ReadKey();
        }
    }

    public class CompanyContext : DbContext
    {
        public DbSet<Company>Company{ get; set; }
        public DbSet<Product> Products { get; set; }

    }
}