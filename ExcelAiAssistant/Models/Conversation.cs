using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ExcelAiAssistant.Languages;

namespace ExcelAiAssistant.Models
{
    public class Conversation
    {
        public string Title { get; set; } = Strings.ChatBox_Caption;
        public Config ModelConfig { get; set; }
        public ObservableCollection<Span> Spans { get; set; } = new ObservableCollection<Span>();
        public DateTime CreateTime { get; set; } = DateTime.Now;

        public bool GetLastQuestionAndAnswer(out string question,out string answer)
        {
            bool found = false;
            question = "";
            answer = "";

            int qIndex = -1;
            //最后一个是当前的问题。
            for (int i = Spans.Count - 2; i >= 0; i--)
            {
                if (Spans[i].IsQuestion)
                {
                    qIndex = i;
                    question = Spans[i].Text;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                for(int i = qIndex+1;i<Spans.Count -1;i++)
                {
                    if (!Spans[i].IsQuestion)
                    {
                        answer += Spans[i].Text + "\n";
                    }
                }
            }

            return found;
        }


        public void AddQuestion(string text)
        {
            if(Spans.Count <= 0)
            {
                //第一次提问，确定标题
                Title = text.Length>20? text.Substring(0, 20)+"..." : text;
            }
            Spans.Add(new Span { Text = text, Type = "Msg", IsQuestion = true });
        }

        public void AddAnswer(string text)
        {
            Spans.Add(new Span { Text = text, Type = "Msg", IsQuestion = false });
        }

        public void AddCode(string text)
        {
            Spans.Add(new Span { Text = text, Type = "Code", IsQuestion = false });
        }

        public void AppendAnswer(string text)
        {
            Spans.Add(new Span { Text = text, Type = "Append", IsQuestion = false });
        }



        public string SaveToFile()
        {
            // 配置序列化设置，忽略空值
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            // 将对象序列化为 JSON 字符串
            string json = JsonConvert.SerializeObject(this, settings);

            // 获取程序集目录
            string assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 创建 history 目录（如果不存在）
            string historyDirectory = Path.Combine(assemblyDirectory, "history");
            if (!Directory.Exists(historyDirectory))
            {
                Directory.CreateDirectory(historyDirectory);
            }

            // 生成文件名
            string fileName = CreateTime.ToString("yyyyMMddHHmmss") + ".txt";
            string filePath = Path.Combine(historyDirectory, fileName);

            // 将 JSON 字符串保存到文件中
            File.WriteAllText(filePath, json);

            return filePath;
        }

        public static ConversationInfo CreateConversationInfo(string file)
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            if (DateTime.TryParseExact(fileName, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime createTime))
            {
                Conversation con = LoadConversationFromFile(file);
                return new ConversationInfo
                {
                    FilePath = file,
                    Content = con,
                    Title = con.Title + " [" + createTime.ToString("MM-dd HH:mm") + "]",
                    CreateTime = createTime
                };
            }
            return null;
        }

        public static List<ConversationInfo> GetHistoryFiles()
        {
            // 获取程序集目录
            string assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 获取 history 目录
            string historyDirectory = Path.Combine(assemblyDirectory, "history");
            if (!Directory.Exists(historyDirectory))
            {
                return new List<ConversationInfo>();
            }

            // 获取所有文件
            var files = Directory.GetFiles(historyDirectory, "*.txt");

            // 解析文件名并创建 ConversationInfo 列表
            var conversationInfos = new List<ConversationInfo>();
            foreach (var file in files)
            {
                try
                {
                    // 从文件名解析 CreateTime
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    if (DateTime.TryParseExact(fileName, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime createTime))
                    {
                        conversationInfos.Add(CreateConversationInfo(file));
                    }
                }
                catch (Exception ex)
                {
                    // 处理解析错误
                    Console.WriteLine($"Error parsing file {file}: {ex.Message}");
                }
            }

            // 按创建时间排序，最近创建的排在最上面
            return conversationInfos.OrderBy(c => c.CreateTime).ToList();
        }


        public static Conversation LoadConversationFromFile(string fileName)
        {
            // 获取程序集目录
            string assemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // 获取 history 目录
            string historyDirectory = Path.Combine(assemblyDirectory, "history");
            if (!Directory.Exists(historyDirectory))
            {
                throw new DirectoryNotFoundException("The history directory does not exist.");
            }

            // 获取文件路径
            string filePath = Path.Combine(historyDirectory, fileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", fileName);
            }

            // 读取文件内容并反序列化为 Conversation 对象
            string json = File.ReadAllText(filePath);
            var conversation = JsonConvert.DeserializeObject<Conversation>(json);
            return conversation;
        }
    }

    public class Span
    {
        public string Text { get; set; }
        public string Type { get; set; } = "Msg";  // Msg, Code
        public bool IsQuestion { get; set; } = false;
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }

    public class ConversationInfo
    {
        public string Title { get; set; }
        public string FilePath { get; set; }
        public DateTime CreateTime { get; set; }
        public Conversation Content{get;set;}
    }


}
