using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizza")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public double Price { get; set; }


        public Pizza(string name, string description, string img, double price)
        {
            Name = name;
            Description = description;
            Img = img;
            Price = price;
        }

    }
}
