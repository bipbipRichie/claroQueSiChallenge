
using System;
using Claro.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Claro.UnitTests
{
    [TestClass]
    public class ClaroUnitTest
    {
        private IMovieService service = new MovieService();

        /// <summary>
        /// Nos aseguramos de que el servicio que nos regresa el listado completo de pelicula este funcionando.
        /// </summary>
        [TestMethod]
        public async void GetMovieList()
        {
            try
            {
                var r = await service.GetMovies("", "50");
                Assert.IsNotNull(r);
            }
            catch(Exception ex)
            {
                Assert.Fail("Prueba fallida.");
            }
}

        /// <summary>
        /// Nos aseguramos de que el servicio que nos regresa el detalle de una pelicula este funcionando.
        /// </summary>
        [TestMethod]
        public async void GetMovie()
        {
            try
            {
                var r = await service.GetMovie("776749");
                Assert.IsNotNull(r);
            }
            catch(Exception ex)
            {
                Assert.Fail("Prueba fallida.");
            }
        }
    }
}
