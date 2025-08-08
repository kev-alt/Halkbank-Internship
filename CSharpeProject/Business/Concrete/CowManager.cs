using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class CowManager : IApplicationService
    {
        public void ApplyForStraw(Cow cow)
        {

        }

        public List<Cow> GetList()
        {
            return null;
        }

        public bool CheckCow(Cow cow)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest
                        (new TCKimlikNoDogrulaRequestBody(cow.Id, cow.FirstName, cow.LastName, cow.DateOfBirth)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
