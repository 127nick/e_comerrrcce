using onticket.data;
using onticket.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onticket.@enum
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

        public moviecat moviecat { get; set; }

        
        public List<actor_movie> actor_Movies { get; set; }


        public int Cinema { get; set; }
        public actor actor { get; set; }



        //cinema

        public Cinema CinemaID { get; set; }

        [ForeignKey("Cinemaid")]
        public Cinema cinema{ get; set; }


 
        //producer
        public Produser produserid { get; set; }

        [ForeignKey("produserid")]
        public Produser produser { get; set; }


    }
}
