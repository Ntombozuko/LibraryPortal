using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LibraryPortal.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }

        [Display(Name = "Page Count")]
        public int PageCount { get; set; }
        public string Publisher { get; set; }

        [Display(Name = "Year Published")]
        [DataType(DataType.Date)]
        public DateTime YearPublished { get; set; }
        public string Amazon { get; set; }
        public string Takealot { get; set; }
        public string Picture { get; set; }

        [NotMapped]
        [DisplayName("Upload file")]
        public IFormFile PictureFile { get; set; }
    }
}
