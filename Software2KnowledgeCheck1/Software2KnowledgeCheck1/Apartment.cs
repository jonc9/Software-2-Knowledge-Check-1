using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }

        public bool HasParking { get; set; }
        public string? OwnerName { get; set; } // moved from HighRise.cs
        public List<string> Directory { get; set; } // moved from HighRise.cs

        public List<Building> Buildings { get; } = new List<Building>();

        
    }
}
