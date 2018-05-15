using PhotoSharingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharingApp.Controller
{
    public class PhotoController : System.Web.Mvc.Controller
    {
        private PhotoSharingContext context= new PhotoSharingContext();
        // GET: Photo
        public ActionResult Index()
        {
            //var photo = new Photo();
            return View(context.Photos.ToList());
            //context.Photos.First<Photo>()
        }

        public ActionResult Display(int id)
        {
            List<Photo> photos = context.Photos.ToList();
            var verif = photos.Find(photo => photo.PhotoID == id);
            if (verif != null)
                return View("Display",verif);
            else
                return HttpNotFound();
        }
        public ActionResult Create()
        {
            Photo photo = new Photo();
            photo.CreateDate= DateTime.Now;
            return View("Create", photo);
        }
        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
                photo.CreateDate= DateTime.Now;
            if (ModelState.IsValid)
            {
                if (image!=null)
                {
                    photo.ImageMimeType = image.ContentType;
                    photo.PhotoFile = new byte[image.ContentLength];
                    image.InputStream.Read(photo.PhotoFile,0,image.ContentLength);
                    context.Photos.Add(photo);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", photo);
            }
        }
    }
    
}