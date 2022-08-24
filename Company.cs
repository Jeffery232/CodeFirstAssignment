using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string URL { get; set; }
        public ProductType ProductType { get; set; } 
        public ICollection<Product> Products { get; set; }

    }

    public enum ProductType
    {
        Production,
        Pharamcetical,
        OilCompany,
        Service,
        FMCG
    }
        public class Product
        {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        }
    }

