using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BootstrapProject.Service.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<ImageEntity> ImageEntitys { get; set; }
    }
}