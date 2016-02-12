/**
 * @module          :   ICommonBusinessObject.cs
 * @version         :   1.0
 * @owner           :   Prantik Kundu
 * @date            :   26th Dec 2015
 * @description     :   This interface content declaration of all common business object methods.
 * 
 * @modification tracking record
 * =======================================================================================================
 * @modified Date           @modified by                        @description
 * -------------------------------------------------------------------------------------------------------
 * 
 * -------------------------------------------------------------------------------------------------------
 */

namespace Metlife.PMS.Infrastructure.BO
{
    //~~~~~~~ System Namespace ~~~~~~~~~~~~~~~~~~
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    //~~~~~~~ Project Namespace ~~~~~~~~~~~~~~~~~
    using Metlife.PMS.Infrastructure.Entities;

    public interface ICommonBusinessObject
    {
        List<Login> GetAllUserDetails();
    }
}
