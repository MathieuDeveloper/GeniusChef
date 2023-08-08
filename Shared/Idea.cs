using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusChef.Shared
{
    public class Idea
    {
        //on utilise pas Guid car OpenIA ne génère pas de Guid mais un int
        public int index { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }

    }
}
