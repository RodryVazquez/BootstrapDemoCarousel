﻿using BootstrapProject.Service.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapProject.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
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

        /// <summary>
        /// 
        /// </summary>
        public List<string> FileNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ImageEntity ToEntity()
        {
            return new ImageEntity()
            {
                UserName = UserName,
                LastName = LastName,
                Extension = Extension,
                FileName = FileName,
                ContentType = ContentType
            };
        }
    }
}