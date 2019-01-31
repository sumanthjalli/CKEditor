using CKEditorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKEditorDemo.Controllers
{
    public class CKEditorController : Controller
    {
        // GET: CKEditor
        CKEditorDemoDBEntities context = new CKEditorDemoDBEntities();

        public ActionResult Index()
        {
            return View();
        }
       [ValidateInput(false)]
        [HttpPost]
        public ActionResult Index(TestModel mdl)
        {
            Test tstobj = new Test();
            tstobj.Title = mdl.Title;
            tstobj.HelpContent = mdl.HelpContent;
            context.Tests.Add(tstobj);
            context.SaveChanges();

            return View();
        }
    }
}