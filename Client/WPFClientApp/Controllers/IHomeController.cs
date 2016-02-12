using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metlife.PMS.Infrastructure.Entities;
using Metlife.PMS.Infrastructure.BO;

namespace Metlife.PMS.ClientApp.Controllers
{
    public interface IHomeController
    {
        List<Login> GetAllUserDetails();
    }
}
