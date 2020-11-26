using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectIdea
{
    class Members
    {
        public string Name { get; set; }
        public Members(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
