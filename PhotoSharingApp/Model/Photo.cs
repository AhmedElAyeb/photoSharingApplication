using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class Photo
    {
        private int PhotoID { get; set; }
        private String Title { get; set; }
        [DisplayName("Picture")]  
        private byte[] PhotoFile { get; set; }
        [DataType(DataType.MultilineText)]
        private String Description { get; set; }
        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yy}",ApplyFormatInEditMode =true)]
        private DateTime CreateDate { get; set; }
        private String Owner { get; set; }
        public virtual Photo photo { get; set; }
    }
}