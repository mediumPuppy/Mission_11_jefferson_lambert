using System.ComponentModel.DataAnnotations;

namespace Mission_11_jefferson_lambert.Models
{   
    public class Book
        // setting the key at the top and all others are set to be required.
    {   
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Publisher { get; set; }
        public string ISBN { get; set; }
        public int Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public float Price { get; set; }
    }
}
