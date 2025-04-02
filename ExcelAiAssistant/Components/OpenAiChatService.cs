using ExcelAiAssistant.Interfaces;
using ExcelAiAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI.Chat;
using System.Net;
using OpenAI;
using System.ClientModel;


namespace ExcelAiAssistant.Components 
{
    public class OpenAiChatService : IChatService
    {
        private readonly Config _config;
        private readonly ChatClient _client;

        public OpenAiChatService(Config cfg)
        {
            _config = cfg;
            OpenAIClientOptions options = new OpenAIClientOptions();
            options.Endpoint = new Uri(cfg.BaseUrl);

            _client = new ChatClient(cfg.ModelName, new ApiKeyCredential(cfg.AppKey), options);
        }

        public async Task<string> SendMessageAsync(string message, Conversation conversation)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // 构建对话历史作为上下文
            var messages = new List<ChatMessage>();

            if (!string.IsNullOrEmpty(_config.SystemPrompt))
            {
                var systemPrompt = new SystemChatMessage(_config.SystemPrompt);
                messages.Add(systemPrompt);
            }

            string lastQuestion = string.Empty;
            string lastAnswer = string.Empty;
            if(conversation.GetLastQuestionAndAnswer(out lastQuestion, out lastAnswer))
            {
                messages.Add(new UserChatMessage(lastQuestion));
                messages.Add(new AssistantChatMessage(lastAnswer));
            }
            messages.Add(new UserChatMessage(message));

            ChatCompletion completion = await _client.CompleteChatAsync(messages);

            return completion.Content[0].Text;
        }
    }
}
