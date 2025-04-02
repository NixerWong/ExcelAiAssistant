using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAiAssistant.Models
{
    public class LangItem
    {
        public string Lang { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Lang;
        }
    }
}
