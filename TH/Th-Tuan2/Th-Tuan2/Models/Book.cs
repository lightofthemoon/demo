using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Th_Tuan2.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;
        public Book()
        {

        }
        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }

        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(250, ErrorMessage ="Tiêu đề sách không được vượt quá 250 kí tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get => title; set => title = value; }
        [StringLength(10, ErrorMessage = "Tác giả sách không được vượt quá 250 kí tự")]
        public string Author { get => author; set => author = value; }
        public string Image_cover { get => image_cover; set => image_cover = value; }
    }
}