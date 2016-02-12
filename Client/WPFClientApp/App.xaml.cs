/**
 * @module          :   App.cs
 * @version         :   1.0
 * @owner           :   Prantik Kundu
 * @date            :   26th Dec 2015
 * @description     :   
 * 
 * @modification tracking record
 * =======================================================================================================
 * @modified Date           @modified by                        @description
 * -------------------------------------------------------------------------------------------------------
 * 
 * -------------------------------------------------------------------------------------------------------
 */

namespace Metlife.PMS.ClientApp
{
    //~~~~~~~~ System Namespace ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bs = new Bootstrapper();
            bs.Run();
        }
    }
}
