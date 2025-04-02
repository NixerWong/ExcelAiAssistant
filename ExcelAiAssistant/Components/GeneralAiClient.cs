using ExcelAiAssistant.Interfaces;
using ExcelAiAssistant.Models;
using Newtonsoft.Json.Linq;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAiAssistant.Components
{
    public class GeneralAiClient : IChatService
    {
        Config _modelConfig;
        HttpClient _client;
       
        public GeneralAiClient(Config cfg)
        {
            _modelConfig = cfg;
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_modelConfig.AppKey}");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> SendMessageAsync(string message, Conversation conversation)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                var messages = new List<JObject>();

                if (!string.IsNullOrEmpty(_modelConfig.SystemPrompt))
                {
                    messages.Add(JObject.FromObject(new { role = "system", content = _modelConfig.SystemPrompt }));
                }

                string lastQuestion = string.Empty;
                string lastAnswer = string.Empty;
                if (conversation.GetLastQuestionAndAnswer(out lastQuestion, out lastAnswer))
                {
                    messages.Add(JObject.FromObject(new { role = "user", content = lastQuestion }));
                    messages.Add(JObject.FromObject(new { role = "assistant", content = lastAnswer}));
                }
                messages.Add(JObject.FromObject(new { role = "user", content = message}));

                var requestData = new
                {
                    model = _modelConfig.ModelName,
                    messages = messages
                };

                var response = await _client.PostAsync(
                    _modelConfig.BaseUrl,
                    new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(requestData),
                        Encoding.UTF8,
                        "application/json"
                    )
                );

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Request Error:{response.StatusCode}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                //return responseContent;
                return ExtractContentFromResponse(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error：{ex.Message}");
            }
        }

        public object[] ConversationToMessages(Conversation conversation)
        {

            return conversation.Spans.Where(span => span.IsQuestion).Select(span => new
            {
                role = "user",
                content = span.Text
            })
            .ToArray();
        }

        public string ExtractContentFromResponse(string jsonResponse)
        {
            var jsonObject = JObject.Parse(jsonResponse);
            var content = jsonObject["choices"]?[0]?["message"]?["content"]?.ToString();
            return content;
        }
    }
}
