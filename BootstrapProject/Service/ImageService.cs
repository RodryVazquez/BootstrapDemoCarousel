using BootstrapProject.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapProject.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageService: IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        private ImageContext _context;

        /// <summary>
        /// 
        /// </summary>
        public ImageService()
        {
            _context = new ImageContext();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<ImageEntity> GetAll()
        {
            return _context.ImageEntitys;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageEntity"></param>
        public void Create(ImageEntity imageEntity)
        {
            _context.ImageEntitys.Add(imageEntity);
            _context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}