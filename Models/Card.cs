using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KayseriUlasimApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

    }
}