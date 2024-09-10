using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteEcom.Pages;

public class AdventureMModel : PageModel
{
    public List<Movie>? AdventureM { get; set; }

    public void OnGet()
    {
        AdventureM = new List<Movie>
        {
            new Movie { Name = "KingsMan", ImageUrl = "/images/Kingsman.jpg", Rating = 4.5 },
            new Movie { Name = "Film Sourcing", ImageUrl = "/images/FilmSourcing.jpg", Rating = 4.2 },
            new Movie { Name = "Thor Ragnarok", ImageUrl = "/images/ThorRagnarok.jpg", Rating = 4.8 },
            // Add more movies here...
        };
    }
}

