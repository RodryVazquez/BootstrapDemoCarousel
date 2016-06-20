using BootstrapProject.Models;
using BootstrapProject.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BootstrapProject.Controllers
{
    /// <summary>
    ///
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        ///
        /// </summary>
        private readonly ImageService _service;

        /// <summary>
        ///
        /// </summary>
        public HomeController()
        {
            _service = new ImageService();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            int maxSlideTo = 4;
            int cont = 0;
            var fileNames = _service.GetAll()
                                    .OrderByDescending(p => p.ImageId)
                                    .Select(p => p.FileName);
            List<string> auxFileNames = new List<string>();
            foreach (var fileName in fileNames)
            {
                if (cont == maxSlideTo)
                {
                    break;
                }
                auxFileNames.Add(fileName);
                cont++;
            }
            var imageModel = new ImageModel(){ FileNames = auxFileNames };

            return View(imageModel);
        }
    }
}