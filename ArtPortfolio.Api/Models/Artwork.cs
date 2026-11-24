namespace ArtPortfolio.Api.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Featured { get; set; }

        public int MediumId { get; set; }
        public Medium Medium { get; set; }
    }
} 
