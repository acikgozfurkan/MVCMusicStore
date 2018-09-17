using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //MusicStoreEntities storeDB = new MusicStoreEntities();
        MvcMusicStoreEntities storeDB = new MvcMusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            //MVC Music Store
            //Deneme Commit

             string name = "Furkan Açıkgöz";

            var genres = storeDB.Genre.ToList();
            return View(genres);
        }



        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genre.Include("Albums")
            .Single(g => g.Name == genre);
            return View(genreModel);
        }


        //GET: /Store /Details
        public ActionResult Details(int id)
        {
            var album = storeDB.Album.Find(id);
            return View(album);
        }



    }
}