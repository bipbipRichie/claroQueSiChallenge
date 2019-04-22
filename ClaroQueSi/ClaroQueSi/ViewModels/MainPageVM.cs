using Claro.Interface;
using Claro.Models.REST;
using ClaroQueSi.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaroQueSi.VM
{
    public class MainPageVM : ViewModelBase
    {
        #region Properties

        private ObservableCollection<Group> _allMovies;
        public ObservableCollection<Group> AllMovies
        {
            get { return _allMovies; }

            set
            {
                _allMovies = value;
                RaisePropertyChanged("AllMovies");
            }
        }

        #endregion


        #region Constructor

        public MainPageVM()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                GetMovies();
            }
        }

        #endregion


        #region Async

        /// <summary>
        /// Metodo que se encarga de obtener el listado de peliculas.
        /// </summary>
        private async void GetMovies()
        {
            try
            {
                IMovieService service = new MovieService();
                var r = await service.GetMovies("", "150");
                AllMovies = new ObservableCollection<Group>(r.response.groups.ToList());
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
