
namespace Mission_11_jefferson_lambert.Models
{
    // ef setup and referencing the dbbookcontext. makilng queryable.
    public class EFBookRepo : IBookRepo
    {
        private DBBookContext _context;
        public EFBookRepo(DBBookContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
