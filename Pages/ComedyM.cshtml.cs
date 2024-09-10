using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteEcom.Pages;

public class ComedyMModel : PageModel
{
    public List<Movie>? ComedyM { get; set; }

    public void OnGet()
    {
        ComedyM = new List<Movie>
        {
            new Movie { Name = "Daddy Day Care", ImageUrl = "/images/DaddyDayCare.jpg", Rating = 4.5 },
            new Movie { Name = "Film Sourcing", ImageUrl = "/images/FilmSourcing.jpg", Rating = 4.2 },
            new Movie { Name = "Little Man", ImageUrl = "/images/LittleMan.jpg", Rating = 4.8 },
            // Add more movies here...
        };
    }
}

