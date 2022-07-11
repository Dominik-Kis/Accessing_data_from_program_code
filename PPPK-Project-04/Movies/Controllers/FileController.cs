using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class FileController : Controller
    {
        ~FileController()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
        private readonly ModelContainer db = new ModelContainer();
        // GET: File
        public ActionResult Index(int id)
        {
            var uploadFile = db.UploadedFiles.Find(id);
            return File(uploadFile.Content, uploadFile.ContentType);
        }
        
        public ActionResult Delete(int id)
        {
            db.UploadedFiles.Remove(db.UploadedFiles.Find(id));
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.AbsolutePath);
        }
    }
}