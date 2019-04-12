using System;

namespace ReplaceJS.Models
{
    public class movies_actors
    {
        public int id {get; set;}
        public int movies_id {get; set;}
        public int actors_id {get; set;}
        public string role {get; set;}

        public movies_actors(){}
        public movies_actors(int Mid, int Aid, string Role)
        {
            movies_id = Mid;
            actors_id = Aid;
            role = Role;
        }
    }
}