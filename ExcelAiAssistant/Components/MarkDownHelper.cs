using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ExcelAiAssistant.Models;
using HeyRed.MarkdownSharp;
using ExcelAiAssistant.Languages;

namespace ExcelAiAssistant.Components
{
    public static class MarkdownHelper
    {
        public static List<Span> ParseMarkdown(string markdown)
        {

            var markdownProcessor = new Markdown();

            var spans = new List<Span>();
            var codeBlockPattern = @"```(.*?)?```";
            var matches = Regex.Matches(markdown, codeBlockPattern, RegexOptions.Singleline);

            int lastIndex = 0;
            bool isFirstText = true;

            foreach (Match match in matches)
            {
                if (match.Index == lastIndex)
                {
                    //光突突的，就加上一小句以缓解尴尬
                    spans.Add(new Span { Text = Strings.Component_TryCode, Type = "Msg" });
                    isFirstText = false;
                }
                else if (match.Index > lastIndex)
                {
                    // 添加代码块前的文本
                    var text = markdown.Substring(lastIndex, match.Index - lastIndex).Trim();
                    if (!string.IsNullOrEmpty(text))
                    {
                        var plainText = markdownProcessor.Transform(text).Trim();
                        spans.Add(new Span { Text = RemoveHtmlTags(plainText), Type = isFirstText ? "Msg" : "Append" });
                        isFirstText = false;
                    }
                }

                // 添加代码块
                var code = match.Groups[1].Value.Trim();
                if (!string.IsNullOrEmpty(code))
                {
                    //第一行无效，要去除。
                    code = code.Substring(code.IndexOf("\n") + 1);
                    spans.Add(new Span { Text = code, Type = "Code" });
                }

                lastIndex = match.Index + match.Length;
            }

            if (lastIndex < markdown.Length)
            {
                // 添加代码块后的文本
                var text = markdown.Substring(lastIndex).Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    var plainText = markdownProcessor.Transform(text).Trim();
                    spans.Add(new Span { Text = RemoveHtmlTags(plainText), Type = isFirstText ? "Msg" : "Append" });
                }
            }

            return spans;
        }

        private static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);
        }
    }
}