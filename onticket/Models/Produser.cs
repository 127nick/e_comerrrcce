


using onticket.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onticket.Models
{
    public class Produser
    {

        [Key]


        public int IdproduserId { get; set; }
        public string profilePiture { get; set; }
        public int Fullname { get; set; }
        public string Bio { get; set; }



        //re[altionship

        [NotMapped]
        public List<Movie>movies { get; set; }
    }

}

