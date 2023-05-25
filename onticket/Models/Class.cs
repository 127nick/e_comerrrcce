using System.ComponentModel.DataAnnotations;

namespace onticket.Models

{
    public class actor 
    {

        [Key]

        
        public int Id { get; set; }
        public string profilePiture { get; set;}    
        public int Fullname { get; set;}
        public string Bio  { get; set;}


        //relationship 
        public List<actor_movie> actors_movie { get; set;}

    }
}
