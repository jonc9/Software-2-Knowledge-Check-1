using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    public interface ICity // changed to interface for Interface segregation principle and I felt it made more since it isn't related to the other classes.
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }      
    }
}
