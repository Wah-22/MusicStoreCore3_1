using Microsoft.AspNetCore.Mvc;
using MusicStoreCore3_1.Models;
using System.Linq;

namespace MusicStoreCore3_1.ViewComponents
{
    public class GenreMenuViewComponent : ViewComponent
    {
        private readonly MusicStoreEntities storeDB;

        public GenreMenuViewComponent(MusicStoreEntities musicStoreEntities)
        {
            this.storeDB = musicStoreEntities;
        }

        public IViewComponentResult Invoke()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }
    }
}