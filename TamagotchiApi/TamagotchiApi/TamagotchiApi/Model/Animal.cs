using System;
using System.Collections.Generic;

#nullable disable

namespace TamagotchiApi.Model
{
    public partial class Animal
    {
        public Animal()
        {
            Pets = new HashSet<Pet>();
        }

        public ulong Id { get; set; }
        public string Animaltype { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
