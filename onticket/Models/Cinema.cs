

using onticket.@enum;
using System.ComponentModel.DataAnnotations;

namespace onticket.Models
{
    public class Cinema
    {
        

        [Key]
        public int Id { get; set; }
         

        public string logo { get; set; }
        public string name { get; set; }
         
        public string description { get; set; }

        public List<Movie>movies { get; set; }  

    }

}

