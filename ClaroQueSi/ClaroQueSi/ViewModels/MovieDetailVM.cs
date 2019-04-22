using Claro.Interface;
using Claro.Models.REST;
using Claro.Models.REST.MovieDetail;
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
    public class MovieDetailVM : ViewModelBase
    {

        #region Properties
        private string _movieOriginalTitle { get; set; }
        public string MovieOriginalTitle
        {
            get { return _movieOriginalTitle; }

            set
            {
                _movieOriginalTitle = value;
                RaisePropertyChanged("MovieOriginalTitle");
            }
        }

        private string _movieTitle { get; set; }
        public string MovieTitle
        {
            get { return _movieTitle; }

            set
            {
                _movieTitle = value;
                RaisePropertyChanged("MovieTitle");
            }
        }

        private string _imageUri { get; set; }
        public string ImageUri
        {
            get { return _imageUri; }

            set
            {
                _imageUri = value;
                RaisePropertyChanged("ImageUri");
            }
        }

        private string _movieDescription { get; set; }
        public string MovieDescription
        {
            get { return _movieDescription; }

            set
            {
                _movieDescription = value;
                RaisePropertyChanged("MovieDescription");
            }
        }

        private string _movieGenres { get; set; }
        public string MovieGenres
        {
            get { return _movieGenres; }

            set
            {
                _movieGenres = value;
                RaisePropertyChanged("MovieGenres");
            }
        }        

        private string _rating { get; set; }
        public string Rating
        {
            get { return _rating; }

            set
            {
                _rating = value;
                RaisePropertyChanged("Rating");
            }
        }

        private string _movieYear { get; set; }
        public string MovieYear
        {
            get { return _movieYear; }

            set
            {
                _movieYear = value;
                RaisePropertyChanged("MovieYear");
            }
        }

        private string _movieDuration { get; set; }
        public string MovieDuration
        {
            get { return _movieDuration; }

            set
            {
                _movieDuration = value;
                RaisePropertyChanged("MovieDuration");
            }
        }

        private ObservableCollection<Claro.Models.REST.Group> _recommendedMovies;
        public ObservableCollection<Claro.Models.REST.Group> RecommendedMovies
        {
            get { return _recommendedMovies; }

            set
            {
                _recommendedMovies = value;
                RaisePropertyChanged("RecommendedMovies");
            }
        }

        private ObservableCollection<Talent> _talents;
        public ObservableCollection<Talent> Talents
        {
            get { return _talents; }

            set
            {
                _talents = value;
                RaisePropertyChanged("Talents");
            }
        }

        private MovieDetailResponse _movieDetailR;
        public MovieDetailResponse MovieDetailR
        {
            get { return _movieDetailR; }

            set
            {
                _movieDetailR = value;
                RaisePropertyChanged("MovieDetailR");
            }
        }

        #endregion
        
        #region Constructor

        public MovieDetailVM()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                GetMovieDetail();
            }
        }

        #endregion
        
        #region Async

        /// <summary>
        /// Metodo que se encarga de obtener los detalles de una de las peliculas seleccionadas.
        /// </summary>
        private async void GetMovieDetail()
        {
            try
            {
                IMovieService service = new MovieService();
                MovieDetailR = await service.GetMovie(ClaroSingleton.GetId());
                var movies = await service.GetMovies("", "16");
                RecommendedMovies = new ObservableCollection<Claro.Models.REST.Group>(movies.response.groups.ToList());
                Talents = new ObservableCollection<Talent>(MovieDetailR.response.group.common.extendedcommon.roles.role.FirstOrDefault().talents.talent.ToList());
                MovieTitle = MovieDetailR.response.group.common.title;
                MovieDescription = MovieDetailR.response.group.common.large_description;
                Rating = MovieDetailR.response.group.common.extendedcommon.media.rating.code;
                MovieYear = MovieDetailR.response.group.common.extendedcommon.media.publishyear;
                MovieOriginalTitle = MovieDetailR.response.group.common.extendedcommon.media.originaltitle;
                MovieDuration = MovieDetailR.response.group.common.duration;
                ImageUri = MovieDetailR.response.group.common.image_base_horizontal;
                foreach (var g in MovieDetailR.response.group.common.extendedcommon.genres.genre)
                {
                    MovieGenres += $"{g.desc} ";
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
}

        #endregion
    }
}
