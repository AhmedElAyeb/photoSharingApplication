using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class Photo
    {
        private int PhotoID { get; set; }
        private String Title { get; set; }
        private List<Byte> PhotoFile { get; set; }
        private String Description { get; set; }
        private DateTime CreateDate { get; set; }
        private String Owner { get; set; }
        public virtual Photo photo { get; set; }
    }
}