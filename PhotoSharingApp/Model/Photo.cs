using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class Photo
    {
        private int PhotoID;
        private String Title;
        private List<Byte> PhotoFile;
        private String Description;
        private DateTime CreateDate;
        private String Owner;
    }
}