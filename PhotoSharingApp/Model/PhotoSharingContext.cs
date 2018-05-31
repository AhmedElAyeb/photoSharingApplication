using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class PhotoSharingContext : System.Data.Entity.DbContext, IPhotoSharingContext
    {
        public DbSet <Photo> Photos { get; set; }

        IQueryable<Comment> IPhotoSharingContext.Comments
        {
            get { return Comments; }
        }
        public DbSet <Comment> Comments { get; set; }


        int IPhotoSharingContext.SaveChanges()
        {
            return SaveChanges();
        }

        T IPhotoSharingContext.Add<T>(T entity)
        {
            return Set<T>().Add(entity);
        }

        Photo IPhotoSharingContext.FindPhotoById(int ID)
        {
            return Set<Photo>().Find(ID);
        }

        Photo IPhotoSharingContext.FindPhotoByTitle(String title)
        {
            List<Photo> photos = new List<Photo>();
            photos = Photos.ToList();
            Photo result = photos.Find(x => x.Title == title);
            return result;
        }

        Comment IPhotoSharingContext.FindCommentById(int ID)
        {
            return Set<Comment>().Find(ID);
        }


        T IPhotoSharingContext.Delete<T>(T entity)
        {
            return Set<T>().Remove(entity);
        }


        IQueryable<Photo> IPhotoSharingContext.Photos
        {
            get { return Photos; }
        }
    }
}