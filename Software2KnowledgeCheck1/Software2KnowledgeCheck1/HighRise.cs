using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class HighRise : Apartment /*Originally inherited Building but upon looking at SOLID principles, I felt Apartment.cs would be better due to it inheriting from building and since a highrise is an apartment, its just dependent on how many feet above ground level. I also moved OwnerName to Apartment due to them being so similar and moved "List<string> Directory" to apartment as well. */
       
    {
        public int NumberOfStories { get; set; }
    }
}
