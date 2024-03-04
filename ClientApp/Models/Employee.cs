using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string department { get; set; }
        [Required]
        public string designation { get; set; }
    }
}