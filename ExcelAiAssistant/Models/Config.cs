using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAiAssistant.Models
{
    public class Config
    {
        public int ModelId { get; set; }
        public string BaseUrl { get; set; }
        public string AppKey { get; set; }
        public string ModelName { get; set; }
        public string ApiType { get; set; } = "Ollama";
        public string Enabled { get; set; }
        public string SystemPrompt { get; set; }
    }
}
