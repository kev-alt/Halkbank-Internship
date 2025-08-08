using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return "44 " + _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
