using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;

        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                new MovieViewModel { Id = 1, Name = "Evil Dead Rise", Details = "https://www.youtube.com/watch?v=smTK_AeAPHs", Description = "The Evil Dead is a 1981 American supernatural horror film written and directed by Sam Raimi (in his feature directorial debut). The film stars Bruce Campbell, Ellen Sandweiss, Richard DeManincor, Betsy Baker, and Theresa Tilly. The story focuses on five college students vacationing in an isolated cabin in a remote wooded area. After they find an audio tape that, when played, releases a legion of demons and spirits, four members of the group suffer from demonic possession, forcing the fifth member, Ash Williams (Campbell), to survive an onslaught of increasingly gory mayhem." },
                new MovieViewModel { Id = 2, Name = "Ballerina", Details = "https://www.youtube.com/watch?v=IhXfUTGVEUI", Description = "Ballerina (Korean: 발레리나), is a 2023 South Korean action thriller film directed by Lee Chung-hyun, starring Jeon Jong-seo, Kim Ji-hoon and Park Yu-rim. It was premiered at 28th Busan International Film Festival in 'Korean Cinema Today – Special Premiere' section on October 5, 2023." },
                new MovieViewModel { Id = 3, Name = "The Nun", Details = "https://www.youtube.com/watch?v=QF-oyCwaArU", Description = "The Nun is a 2018 American gothic supernatural horror film directed by Corin Hardy and written by Gary Dauberman, from a story by Dauberman and James Wan.[2][3] It is a spin-off/prequel of 2016's The Conjuring 2 and the fifth installment in The Conjuring Universe franchise. The film stars Taissa Farmiga, Demián Bichir and Jonas Bloquet, with Bonnie Aarons reprising her role as the Demon Nun, an incarnation of Valak, from The Conjuring 2. The plot follows a Roman Catholic priest and a nun in her novitiate as they uncover an unholy secret in 1952 Romania." },
                new MovieViewModel { Id = 4, Name = "Smile", Details = "https://www.youtube.com/watch?v=BcDK7lkzzsU", Description = "Smile is a 2022 American psychological supernatural horror film written and directed by Parker Finn (in his feature directorial debut), based on his 2020 short film Laura Hasn't Slept. " },
                new MovieViewModel { Id = 5, Name = "Totally killer", Details = "https://www.youtube.com/watch?v=vNm3VPPKEQI", Description = "Totally Killer is a 2023 American black comedy slasher film directed by Nahnatchka Khan from a screenplay by David Matalon, Sasha Perl-Raver, and Jen D'Angelo, and a screen story by Matalon and Perl-Raver." },
                new MovieViewModel { Id = 6, Name = "Scream", Details = "https://www.youtube.com/watch?v=h74AXqw4Opc", Description = "Scream VI is a 2023 American slasher film directed by Matt Bettinelli-Olpin and Tyler Gillett, and written by James Vanderbilt and Guy Busick. It is the sequel to Scream (2022) and the sixth installment in the Scream film series. " },
                new MovieViewModel { Id = 7, Name = "Mary Cherry", Details = "https://www.youtube.com/watch?v=klhnQptq0ow", Description = "Mary Cherry Chua is based on a popular urban legend about a pretty high school lass named Mary Cherry Chua, who was reportedly murdered by the school janitor. The horror film centers on Karen (Ashley Diaz), who is fond of reading campus horror tales and urban legends." },
                new MovieViewModel { Id = 8, Name = "Where the devil roams", Details = "https://www.youtube.com/watch?v=U4MvHEzUYaA", Description = "A family of murderous sideshow performers travels around the world on the dying carnival circuit." },
                new MovieViewModel { Id = 9, Name = "The Pope's Exorcist", Details = "https://www.youtube.com/watch?v=YJXqvnT_rsk", Description = "Father Gabriele Amorth, chief exorcist for the Vatican, battles Satan and innocent-possessing demons. A detailed portrait of a priest who performed more than 100,000 exorcisms in his lifetime." },
                new MovieViewModel { Id = 10, Name = "Para Betina Pengikut Iblis", Details = "https://www.youtube.com/watch?v=gOdG7UUwEg8", Description = "Three women in a small village conceal dark secrets, including unholy alliances and a mysterious ingredient used in a popular curry restaurant." },
                new MovieViewModel { Id = 11, Name = "The Strays", Details = "https://www.youtube.com/watch?v=o9_UteTT9wA", Description = "A light-skinned Black woman's meticulously crafted life of privilege starts to unravel when two strangers show up in her quaint suburban town." },
                new MovieViewModel { Id = 12, Name = "The Strays", Details = "https://www.youtube.com/watch?v=zdDN_mflfSY", Description = "After a mysterious force decimates the world's population, Sebastian must navigate his own survival journey through the desolate streets of Barcelona." },
            };
        }

        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }

        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);
        }
    }
}
