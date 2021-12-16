using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MovieList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Films> films;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            films = new List<Films>();

            films.Add(new Films()
            {
                Title = "Teeja Punjab (The Origin Of 3rd Punjab)",
                Duration = "2h 18m",
                Description = "A true story of farmers of Punjab. " +
                " The farmers of punjab doing protest on Delhi Borders against 3 black farm laws to protect their property(fields)" +
                "and, urging government to repeal these laws." +
               " Finally after staying 381 days or borders, government take these laws back and farmers return their homes (Punjab happily."
            });

            films.Add(new Films()
            {
                Title = "Encanto",
                Duration = "1h 48m",
                Description = "The Madrigals are an extraordinary family who live hidden in the mountains of Colombia in a charmed place called the Encanto. " +
                "The magic of the Encanto has blessed every child in the family with a unique gift -- every child except Mirabel." +
                " However, she soon may be the Madrigals last hope when she discovers that the magic surrounding the Encanto is now in danger."
            });
                

            films.Add(new Films()
            {
                Title = "Frozen 2",
                Duration = "1h 58m",
                Description = "Queen Elsa begins to hear a mysterious melodic voice calling to her." +
                "Unsettled, she answers it, thus awakening the elemental spirits and setting into motion a quest to restore an old injustice."
            });

            films.Add(new Films()
            {
                Title = "The Grinch",
                Duration = "1h 25m",
                Description = "The Grinch grows increasingly annoyed with the ever-growing festive cheer that engulfs the village of Whoville."+
                "So, he teams up with his dog to ruin the festive spirit by being a spoilsport."
            });

        }

        public void OnGet()
        {

        }
    }
}
