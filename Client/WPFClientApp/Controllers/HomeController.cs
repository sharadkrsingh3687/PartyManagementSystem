using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metlife.PMS.Infrastructure.BO;
using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.ClientApp.Controllers
{
    public class HomeController : IHomeController
    {
        private ICommonBusinessObject _commonBizObj;
        public HomeController()
        {
            _commonBizObj = new CommonBusinessObject();
        }
        public List<Login> GetAllUserDetails()
        {
            return _commonBizObj.GetAllUserDetails();
        }
    }
}
