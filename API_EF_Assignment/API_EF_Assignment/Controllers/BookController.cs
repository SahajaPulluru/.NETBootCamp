using Microsoft.AspNetCore.Mvc;
using API_EF_Assignment.Repositories;
using API_EF_Assignment.Entities;
namespace API_EF_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }

        //Endpoints
        [HttpGet, Route("GetBooks")]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, bookRepository.GetBooks());
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet, Route("GetBook/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBook(id));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByName/{name}")]
        public IActionResult GetBookByName(string name)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByName(name));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByAuthor(author));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByPublisher/{publisher}")]
        public IActionResult GetBookByPublisher(string publisher)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByPublisher(publisher));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, Route("AddBook")]
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bookRepository.Delete(id);
                return StatusCode(200, "Book with " + id + " Deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut,Route("Edit")]
        public IActionResult Edit(Book book)
        {
            try
            {
                bookRepository.Edit(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
