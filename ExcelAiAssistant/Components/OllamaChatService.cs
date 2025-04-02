using ExcelAiAssistant.Interfaces;
using ExcelAiAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OllamaSharp;
using System.Threading;

namespace ExcelAiAssistant.Components
{
    public class OllamaChatService : IChatService
    {
        private readonly OllamaApiClient _client;
        private readonly Chat _chat;
        private readonly Config _config;

        public OllamaChatService(Config cfg)
        {
            _config = cfg;
            var uri = new Uri(_config.BaseUrl);
            _client = new OllamaApiClient(uri);
            _client.SelectedModel = _config.ModelName;
            _chat = new Chat(_client, _config.SystemPrompt);
        }

        public async Task<string> SendMessageAsync(string message, Conversation conversation)
        {
            string response = string.Empty;
            var cancellationToken = new CancellationToken();

            var connected = await _client.IsRunningAsync(cancellationToken);
            if (connected)
            {
                // 维护对话上下文
                var context = string.Join("\n", conversation.Spans.Select(s => s.Text));
                Action<string> processAnswerToken = token =>
                {
                    response += token;
                };

                await _chat.SendAsync(message, cancellationToken).StreamToEndAsync(processAnswerToken);
            }
            else
            {
                response = "Can not connenct to AI Api Server.";
            }

            return response;
        }
    }
}
