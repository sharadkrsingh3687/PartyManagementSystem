/**
 * @module          :   CommonBusinessObject.cs
 * @version         :   1.0
 * @owner           :   Prantik Kundu
 * @date            :   26th Dec 2015
 * @description     :   This business object class content all common business logic methods that  
 *                      used in application. 
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
    using Metlife.PMS.Infrastructure.DataAccess;

    public class CommonBusinessObject : ICommonBusinessObject
    {
        #region Private Property
        private PMDatabaseContext dbObj;
        #endregion
        public CommonBusinessObject()
        {
            dbObj = new PMDatabaseContext();
        }

        public List<Login> GetAllUserDetails()
        {
            try
            {
                return dbObj.Logins.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
