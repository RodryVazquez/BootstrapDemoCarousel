using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapProject.Service.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContentType { get; set; }
        
    }
}