using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    internal class WordEntry
    {
        public string Title { get; set; }

        public string Language { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
