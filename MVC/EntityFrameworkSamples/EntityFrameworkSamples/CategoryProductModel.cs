using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class CategoryProductModel
    {
        public string CategoryName { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
