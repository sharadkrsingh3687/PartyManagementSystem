/**
 * @module          :   Bootstrapper.cs
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
    //~~~~ System Namespace ~~~~~~~~~~~~~~~~~~~~~~~
    using System;
    using System.Windows;
    using System.Configuration;
    //~~~~ Microsoft Namespace ~~~~~~~~~~~~~~~~~~~~
    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;
    using Microsoft.Practices.ServiceLocation;
    //~~~~ Prism Namespace ~~~~~~~~~~~~~~~~~~~~~~~~
    using Prism.Unity;    
    //~~~~ Project Namespace ~~~~~~~~~~~~~~~~~~~~~~
    using Metlife.PMS.ClientApp.Views;

    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow.Show();
        }
    }
}
