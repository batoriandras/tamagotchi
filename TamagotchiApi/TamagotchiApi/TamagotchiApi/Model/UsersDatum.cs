using System;
using System.Collections.Generic;

#nullable disable

namespace TamagotchiApi.Model
{
    public partial class UsersDatum
    {
        public UsersDatum()
        {
            Pets = new HashSet<Pet>();
        }

        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
