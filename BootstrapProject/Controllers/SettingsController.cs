using BootstrapProject.Models;
using BootstrapProject.Service;
using BootstrapProject.Service.Entity;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace BootstrapProject.Controllers
{
    /// <summary>
    ///
    /// </summary>
    public class SettingsController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ImageService _service;

        /// <summary>
        /// 
        /// </summary>
        public SettingsController()
        {
            _service = new ImageService();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var imageModel = new ImageModel();
            imageModel.FileNames = _service.GetAll()
                                           .Select(p => p.FileName)
                                           .ToList();
            return View(imageModel);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="postedFile"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ImageModel imageModel, HttpPostedFileBase postedFile)
        {
            var relativePath = WebConfigurationManager.AppSettings["ImageCarouselRoute"];

            if (imageModel != null && ModelState.IsValid)
            {
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    Guid uniqueId = Guid.NewGuid();
                    var fileName = Path.GetFileName(postedFile.FileName);
                    var extension = Path.GetExtension(postedFile.FileName);
                    var contentType = postedFile.ContentType;

                    var internalName = uniqueId.ToString() + extension;
                    imageModel.Extension = extension;
                    imageModel.FileName = internalName;
                    imageModel.ContentType = contentType;

                    var physicalPath = Path.Combine(Server.MapPath("/"), relativePath, internalName);
                    postedFile.SaveAs(physicalPath);

                    var imageEntity = imageModel.ToEntity();
                    _service.Create(imageEntity);
                   
                    return RedirectToAction("Index","Home");
                }
            }
            return View(imageModel);
        }
    }
}