using System;

namespace ReplaceJS.Models
{
    public class movies
    {
        public int id {get; set;}
        public string name {get; set;}
        public string description{get; set;}
        public DateTime release_date{get; set;}
        public int rating {get; set;}
        public DateTime created_at {get; set;} = DateTime.Now;
        public DateTime updated_at {get; set;} = DateTime.Now;
        public movies(){}
        public movies(string Name, string Desc, DateTime ReleaseDate, int Rating)
        {
            name = Name;
            description = Desc;
            release_date = ReleaseDate;
            rating = Rating;
        }
    }
}