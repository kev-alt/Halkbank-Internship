using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class Farmer : ISupplierService
    {
        private IApplicationService _applicationService;

        public Farmer(IApplicationService applicationService) // Constructor
        {
            _applicationService = applicationService;
        }

        public void GiveStraw(Cow cow)
        {
            if (_applicationService.CheckCow(cow))
            {
                Console.WriteLine("Straw was given for " + cow.FirstName);
            }
            else
            {
                Console.WriteLine("Straw was not given for " + cow.FirstName);
            }
        }
    }
}
