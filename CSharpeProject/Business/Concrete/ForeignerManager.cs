using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Business.Abstract;


namespace Business.Concrete
{
    public class ForeignerManager : IApplicationService
    {
        public void ApplyForStraw(Cow cow)
        {
            throw new NotImplementedException();
        }

        public bool CheckCow(Cow cow)
        {
            throw new NotImplementedException();
        }

        public List<Cow> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
