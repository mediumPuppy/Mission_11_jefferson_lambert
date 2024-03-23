namespace Mission_11_jefferson_lambert.Models
{
    // initial setting up of interface for future reference.
    public interface IBookRepo
    {
        public IQueryable<Book> Books { get; }
    }
}
