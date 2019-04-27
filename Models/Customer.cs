﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
    }
}
