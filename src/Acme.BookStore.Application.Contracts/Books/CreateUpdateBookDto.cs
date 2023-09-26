using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        public Guid AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public BookType Type { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
