using Microsoft.AspNetCore.Mvc;
using MusicStoreCore3_1.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreCore3_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly MusicStoreEntities storeDB;
        public HomeController(MusicStoreEntities musicStoreEntities)
        {
            storeDB = musicStoreEntities;
        }

        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);

            return View(albums);
        }

        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}
