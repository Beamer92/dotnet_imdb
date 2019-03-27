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
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        public actor(){}
        public actor(int Id, string Name, string Bio, string profile, DateTime BD, DateTime created,  DateTime updated)
        {
            id = Id;
            name = Name;
            biography = Bio;
            profile_url = profile;
            birth_date = BD;
            created_at = created;
            updated_at = updated;
        }
    }
}