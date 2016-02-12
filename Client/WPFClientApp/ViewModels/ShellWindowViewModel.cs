using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

using Prism.Mvvm;
using Prism.Commands;

using Metlife.PMS.ClientApp.Views;


namespace Metlife.PMS.ClientApp.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        #region Private Property
        private ContentControl _contentControl;
        #endregion

        #region Public Property
        public ContentControl ContentControl 
        { 
            get { return _contentControl; } 
            set { SetProperty(ref _contentControl, value); } 
        }
        #endregion
        public ShellWindowViewModel()
        {
            
        }

        public void AddContentinWindow()
        {
            SetContentControl(new HomeView(), SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight - 30);
        }
        private void SetContentControl(Object objView, double width, double height)
        {
            try
            {
                ContentControl.Width = width;
                ContentControl.Height = height;
                ContentControl.Content = objView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
