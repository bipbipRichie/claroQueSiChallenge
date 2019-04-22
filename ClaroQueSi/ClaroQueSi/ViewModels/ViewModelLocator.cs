using ClaroQueSi.VM;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClaroQueSi.ViewModels
{
    /// <summary>
    /// ServiceLocatro de MVVMLight para el binding a traves de IoC.
    /// </summary> 
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Control InDseignMode....
            }
            else
            {
                // Servicios y Modelos en runtime...
            }

            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<MainPageVM>();
            SimpleIoc.Default.Register<MovieDetailVM>();

        }


        /// <summary>
        /// Obtiene el VM de la Pagina Principal
        /// </summary>
        public MainPageVM MainPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageVM>();
            }
        }

        /// <summary>
        /// Obtiene el VM de la Pagina de Movie Detail
        /// </summary>
        public MovieDetailVM MovieDetailPageInstance
        {
            get
            {
                return new MovieDetailVM();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Cleanup()
        {
            
        }
    }

}
