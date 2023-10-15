using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {

            new MovieViewModel { Id = 1, Name = "Evil Dead Rise", Rating = "9", Image = "css/pictures/10.jpg", Description = "Smile is a 2022 American psychological supernatural horror film written and directed by Parker Finn (in his feature directorial debut), based on his 2020 short film Laura Hasn't Slept. " },
            new MovieViewModel { Id = 2, Name = "Ballerina", Rating = "1", Image = "css/pictures/8.jpg", Description = "Ballerina (Korean: 발레리나), is a 2023 South Korean action thriller film directed by Lee Chung-hyun, starring Jeon Jong-seo, Kim Ji-hoon and Park Yu-rim. It was premiered at 28th Busan International Film Festival in 'Korean Cinema Today – Special Premiere' section on October 5, 2023." },
            new MovieViewModel { Id = 3, Name = "The Nun", Rating = "8", Image = "css/pictures/9.jpg", Description = "The Nun II (also known as The Nun: Chapter Two) is a 2023 American gothic supernatural horror film directed by Michael Chaves, with a screenplay written by Ian Goldberg, Richard Naing, and Akela Cooper from a story by Cooper." },
            new MovieViewModel { Id = 4, Name = "Smile", Rating = "4", Image = "css/pictures/11.jpg", Description = "Smile is a 2022 American psychological supernatural horror film written and directed by Parker Finn (in his feature directorial debut), based on his 2020 short film Laura Hasn't Slept." },
            new MovieViewModel { Id = 5, Name = "Totally Killer", Rating = "7", Image = "css/pictures/14.jpg", Description = "When the infamous Sweet Sixteen Killer returns 35 years after his first murder spree to claim another victim, 17-year-old Jamie accidentally travels back in time to 1987, determined to stop the killer before he can start." },
            new MovieViewModel { Id = 6, Name = "Scream", Rating = "3", Image = "css/pictures/15.jpg", Description = "In the next installment, the survivors of the Ghostface killings leave Woodsboro behind and start a fresh chapter in New York City." },
            new MovieViewModel { Id = 8, Name = "Mary Cherry", Rating = "11", Image = "css/pictures/17.jpg", Description = "Mary Cherry Chua is based on a popular urban legend about a pretty high school lass named Mary Cherry Chua, who was reportedly murdered by the school janitor. The horror film centers on Karen (Ashley Diaz), who is fond of reading campus horror tales and urban legends." },
            new MovieViewModel { Id = 9, Name = "Where the devil roams", Rating = "6", Image = "css/pictures/99.jpg", Description = "Traces a family of murderous sideshow performers as it travels around the world on the dying carnival circuit." },
            new MovieViewModel { Id = 10, Name = "The Pope's Exorcist", Rating = "12", Image = "css/pictures/33.jpg", Description = "The Pope's Exorcist is a 2023 supernatural horror film directed by Julius Avery from a screenplay by Michael Petroni and Evan Spiliotopoulos, based on the 1990 book An Exorcist Tells His Story and the 1992 book An Exorcist: More Stories by Father Gabriele Amorth.[6] The film stars Russell Crowe as Amorth, with Daniel Zovatto, Alex Essoe, and Franco Nero in supporting roles." },
            new MovieViewModel { Id = 11, Name = "Para Betina Pengikut Iblis", Rating = "10", Image = "css/pictures/66.jpg", Description = "Para Betina Pengikut Iblis adalah film horor jagal Indonesia tahun 2023 yang disutradarai oleh Rako Prijanto. Film yang ditayangkan pada 16 Februari 2023 ini dibintangi oleh Mawar de Jongh, Hanggini, Sara Fajira, dan Adipati Dolken." },
            new MovieViewModel { Id = 12, Name = "The Strays", Rating = "5", Image = "css/pictures/44.jpg", Description = "The Strays is a 2023 British horror thriller film written and directed by Nathaniel Martello-White, in his directorial debut. In the film, Neve (Ashley Madekwe) is a biracial upper-class woman leading an idyllic life with her family. As a socialite in her community and the deputy headmistress of a private school, Neve's privileged life is jeopardized when her troubled past resurfaces to undermine everything she has built." },
            new MovieViewModel { Id = 13, Name = "Bird Box Barcelona", Rating = "2", Image = "css/pictures/00.jpg", Description = "Bird Box Barcelona is a 2023 Spanish post-apocalyptic horror thriller film directed and written by Álex and David Pastor. A spin-off sequel to the 2018 film Bird Box, adapted from Josh Malermans 2014 novel of the same name it was released on Netflix on July 14, 2023 to mixed reviews." },
             

        };
    }
    public IActionResult Index()
        {
            return View(_movies);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
}
