using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Th_Tuan2.Models;

namespace Th_Tuan2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Books()
        {
            return View();
        }
        public string HelloTeacher()
        {
            return "Hello Trần Đăng Khoa";
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML là một môn học thú vị!");
            books.Add("HTML is the best");
            books.Add("Bạn phải học HTML!");
            books.Add("Phải học HTML thiệt giỏi!");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBooksModel() {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML là một môn học thú vị!", "Author Name Book 1", "/Content/img/book1.jpg"));
            books.Add(new Book(2, "HTML là một môn học thú vị!", "Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "HTML là một môn học thú vị!", "Author Name Book 3", "/Content/img/book3.jpg"));
            return View(books);
        }
        public ActionResult Edit(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML là một môn học thú vị!", "Author Name Book 1", "/Content/img/book1.jpg"));
            books.Add(new Book(2, "HTML là một môn học thú vị!", "Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "HTML là một môn học thú vị!", "Author Name Book 3", "/Content/img/book3.jpg"));
            Book book = new Book();
            foreach(Book temp in books)
            {
                if(temp.Id == id)
                {
                    book = temp;
                    break;
                }
            }
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost,ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string Title, string Author, string Image_cover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML là một môn học thú vị!", "Author Name Book 1", "/Content/img/book1.jpg"));
            books.Add(new Book(2, "HTML là một môn học thú vị!", "Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "HTML là một môn học thú vị!", "Author Name Book 3", "/Content/img/book3.jpg"));
            if(id == null)
            {
                return HttpNotFound();
            }
            foreach (Book temp in books)
            {
                if (temp.Id == id)
                {
                    temp.Title = Title;
                    temp.Author = Author;
                    temp.Image_cover = Image_cover;
                    break;
                }
            }
            return View("ListBooksModel", books);
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "Id, Title, Author, ImageCover")]Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML là một môn học thú vị!", "Author Name Book 1", "/Content/img/book1.jpg"));
            books.Add(new Book(2, "HTML là một môn học thú vị!", "Author Name Book 2", "/Content/img/book2.jpg"));
            books.Add(new Book(3, "HTML là một môn học thú vị!", "Author Name Book 3", "/Content/img/book3.jpg"));
            try
            {
                if(ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            return View("ListBooksModel",books);
        }
    }
}