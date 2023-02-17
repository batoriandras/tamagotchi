using System;
using System.Collections.Generic;

#nullable disable

namespace TamagotchiApi.Model
{
    public partial class FailedJob
    {
        public ulong Id { get; set; }
        public string Uuid { get; set; }
        public string Connection { get; set; }
        public string Queue { get; set; }
        public string Payload { get; set; }
        public string Exception { get; set; }
        public DateTime FailedAt { get; set; }
    }
}
