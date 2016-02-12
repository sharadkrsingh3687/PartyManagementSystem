using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;
using Prism.Commands;

using Metlife.PMS.ClientApp.Controllers;
using Metlife.PMS.Infrastructure.Entities;

namespace Metlife.PMS.ClientApp.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private IHomeController _homeControllerObj;
            
        public HomeViewModel()
        {
            _homeControllerObj = new HomeController();
            List<Login> lstLoginDetails = _homeControllerObj.GetAllUserDetails();
        }
    }
}
