using System;
using System.Collections.Generic;

#nullable disable

namespace TamagotchiApi.Model
{
    public partial class Pet
    {
        public ulong Id { get; set; }
        public ulong UsersDataId { get; set; }
        public ulong AnimalsId { get; set; }
        public string Petname { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Mood { get; set; }
        public DateTime Birth { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Animal Animals { get; set; }
        public virtual UsersDatum UsersData { get; set; }
    }
}
