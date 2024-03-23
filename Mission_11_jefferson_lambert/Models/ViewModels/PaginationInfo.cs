namespace Mission_11_jefferson_lambert.Models.ViewModels
{
    public class PaginationInfo
        // getting and setting all the items needed for our pagination
    {
        public int TotalItems { get; set; } 
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int)(Math.Ceiling((decimal)TotalItems / ItemsPerPage));
    }
}
