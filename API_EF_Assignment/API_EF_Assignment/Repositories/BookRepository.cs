using API_EF_Assignment.Entities;
using System.Xml.Linq;

namespace API_EF_Assignment.Repositories
{
    public class BookRepository
    {
        private readonly AssignmentDBContext db;
        public BookRepository()
        {
            this.db = new AssignmentDBContext();
        }
        public List<Book> GetBooks()
        {
            try
            {
                return db.Books.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Book GetBook(int bid)
        {
            try
            {
                return db.Books.Find(bid);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Book GetBookByName(string name)
        {
            try
            {
                return db.Books.FirstOrDefault(i => i.BookName == name);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Book GetBookByAuthor(string author)
        {
            try
            {
                return db.Books.FirstOrDefault(i => i.Author == author);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Book GetBookByPublisher(string publisher)
        {
            try
            {
                return db.Books.FirstOrDefault(i => i.Publisher == publisher); ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddBook(Book book)
        {
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                Book book = db.Books.SingleOrDefault(i => i.BookId == id);
                db.Books.Remove(book);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }

        public void Edit(Book book)
        {
            try
            {
                db.Books.Update(book);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }

        }
    }
}
