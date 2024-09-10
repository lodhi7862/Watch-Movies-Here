using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteEcom.Pages;

public class ActionMModel : PageModel
{
    
    public List<Movie>? ActionM { get; set; }

    public void OnGet()
    {
        ActionM = new List<Movie>
        {
            new Movie { Name = "World War Z", ImageUrl = "/images/WorldWarZ.jpg", VideoUrl = "/videos/Trailer.mp4", Rating = 4.5 },
            new Movie { Name = "Black Panther", ImageUrl = "/images/BlackPanther.jpg", VideoUrl = "/videos/Trailer.mp4", Rating = 4.2 },
            new Movie { Name = "Thor Ragnarok", ImageUrl = "/images/ThorRagnarok.jpg", VideoUrl = "/videos/Trailer.mp4", Rating = 4.8 },
            // Add more movies here...
        };
    }
    
}

