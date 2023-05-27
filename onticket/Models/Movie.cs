using onticket.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onticket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public double price { get; set; }
        public string imageurl { get; set; }
        public Moviecat moviecat { get; set; }
        public List<actor_movie> actor_Movies { get; set; }

        public int CinemaId { get; set; } // Change property name to "CinemaId" instead of "Cinema"
        public Cinema Cinema { get; set; }

        public int produserId { get; set; } // Change property name to "produserId" instead of "produser"
        public Produser Produser { get; set; }
    }
}
