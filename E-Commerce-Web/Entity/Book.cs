using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name cannot be empty !!")]
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price required !!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Author Name required !!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Book type required !!")]
        public string Type { get; set; }
        public string ImagePath { get; set; }

        [NotMapped]
        public int Quantity { get; set; }

        [NotMapped]
        public double TotalPrice { get; set; }
    }
}
