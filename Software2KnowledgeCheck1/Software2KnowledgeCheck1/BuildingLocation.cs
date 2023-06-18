using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class BuildingLocation : ICity // changed from Building to BuildingLocation. i felt it more suitable due to its properties.
    {
        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public int ZipCode { get; set; } //added line 15 to 18 from City.cs
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }
    }
}
