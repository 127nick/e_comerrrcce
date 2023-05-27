using System.ComponentModel.DataAnnotations.Schema;

namespace onticket.Models
{
    public class actor_movie
    {
        public int movieid { get; set; }
        public Movie movie { get; set; }
        public int Actorid { get; set; }
        public actor actor { get; set; }





        
    }
}
