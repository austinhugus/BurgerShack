using System;
using System.ComponentModel.DataAnnotations;

namespace burgershack.Models {
    public class Burger {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range (.01, double.MaxValue)]
        public double Price { get; set; }
        public string Description { get; set; }

        public Burger () {
            // Id = Guid.NewGuid().ToString();
        }

        // Note only used for FakeDb
        public Burger (string name, double price, string description) {
            Name = name;
            Price = price;
            Description = description;
            // Id = Guid.NewGuid().ToString();
        }
    }
}