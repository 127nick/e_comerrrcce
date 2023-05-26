

using onticket.@enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public List<Movie> Movies { get; set; } // Modify property name to "Movies" instead of "movies"
    }


}

