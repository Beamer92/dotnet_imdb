using System;

namespace ReplaceJS.Models
{
    public class actor
    {
        public int id {get; set;}
        public string name {get; set;}
        public string biography {get; set;}
        public string profile_url {get; set;}
        public DateTime birth_date {get; set;}
        public DateTime created_at {get; set;} = DateTime.Now;
        public DateTime updated_at {get; set;} = DateTime.Now;
        public actor(){}
        public actor(string Name, string Bio, string profile, DateTime BD)
        {
            name = Name;
            biography = Bio;
            profile_url = profile;
            birth_date = BD;
        }
    }
}