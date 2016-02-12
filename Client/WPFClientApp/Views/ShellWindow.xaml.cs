/**
 * @module          :   ShellWindow.cs
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

namespace Metlife.PMS.ClientApp.Views
{
    //~~~~~~~~ System Namespace ~~~~~~~~~~~~~~~~~~
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    //~~~~~~~~ Project Namespace ~~~~~~~~~~~~~~~~~
    
    /// <summary>
    /// Interaction logic for ShellWindow.xaml
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindow()
        {
            InitializeComponent();
            ((dynamic)this.DataContext).AddContentinWindow();
        }
    }
}
