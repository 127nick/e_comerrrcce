


using onticket.@enum;
using System.ComponentModel.DataAnnotations;

namespace onticket.Models
{
    public class Produser
    {

        [Key]


        public int Id { get; set; }
        public string profilePiture { get; set; }
        public int Fullname { get; set; }
        public string Bio { get; set; }



        //realtionship
        public List<Movie>movies { get; set; }
    }

}

