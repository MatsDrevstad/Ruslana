using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRuslana.Abstract;
using MvcRuslana.Entities;


namespace MvcRuslana.Controllers
{
    public class BloggController : Controller
    {
        //
        // GET: /Blogg/

        private IBlogRepository repository;
        
        public BloggController (IBlogRepository blogRepository)
	    {
            this.repository = blogRepository;
    	}

        public ViewResult Index()
        {
            return View(repository.BlogItems);
        }

        public ViewResult BlogDetail(int id = 1)
        {
            var blogItem = repository.BlogItems.FirstOrDefault(item => item.Id == id);
            return View(blogItem);
        }
    }
}
