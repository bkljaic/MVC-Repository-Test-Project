using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMovieDatabaseFirst.Controllers;
using System.Web.Mvc;
using System.IO;

namespace MvcMovieDatabaseFirst.Tests.Controllers
{
    [TestClass]
    public class MovieControllerTest
    {

        //private static string GetAppDataDirectoryForTesting()
        //{   //NOTE: must be using visual studio test tools for this to work
        //    string path = AppDomain.CurrentDomain.BaseDirectory;
        //    var dirs = path.Split(Path.DirectorySeparatorChar);

        //    var appDataPath = "";
        //    for (int i = 0; i < dirs.Length - 3; i++)
        //    {
        //        appDataPath += dirs[i] + Path.DirectorySeparatorChar.ToString();
        //    }

        //    appDataPath = appDataPath + "MvcMovieDatabaseFirst" + Path.DirectorySeparatorChar.ToString() + "App_Data";
           
            
        //    return appDataPath;
        //}

        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    GetAppDataDirectoryForTesting();
        //    //AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases"));
        //}

       
        [TestMethod]
        public void IndexMovie()
        {

           
            // Arrange
            MoviesController controller = new MoviesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
