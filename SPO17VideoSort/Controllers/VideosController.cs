using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPO17VideoSort.Data.Entities;
using SPO17VideoSort.Services;

namespace SPO17VideoSort.Controllers
{
    public class VideosController : Controller
    {
        public ISqlService _db { get; set; }
        public VideosController(ISqlService db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //var videos = _db.Get<Video>().Include("Genre");
            _db.Include<Video>(new string[] { "Genre" });
            var videos = _db.Get<Video>();
            ViewData["Filter"] = "";
            return View(videos);
        }

        public IActionResult Sort(string column, bool ascending, string filter)
        {
            ViewData["Filter"] = filter;
            _db.Include<Video>(new string[] { "Genre" });
            var videos = _db.Get<Video>();
            if(filter!=null && filter.Length>0)
                videos = videos.Where(v => v.Title.StartsWith(filter));

            #region Sort
            if (ascending)
            {
                if (column.ToLower().Equals("genre"))
                    videos = videos.OrderBy(ob => ob.Genre.Name);
                else
                    videos = videos.OrderBy(s => s.GetType().GetProperty(column).GetValue(s));
            }
            else // Descending
            {
                if (column.ToLower().Equals("genre"))
                    videos = videos.OrderByDescending(ob => ob.Genre.Name);
                else
                    videos = videos.OrderByDescending(s => s.GetType().GetProperty(column).GetValue(s));
            }
            #endregion
      
            

            return View("Index", videos);
        }
    }
}