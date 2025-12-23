using System.Collections.Generic;
using LLMChatbot.Models;

namespace LLMChatbot.Core
{
    public class ChatSession
    {
        public List<Message> Messages { get; } = new();

        public void AddUserMessage(string text)
        {
            Messages.Add(new Message
            {
                Role = "user",
                Content = text
            });
        }

        public void AddBotMessage(string text)
        {
            Messages.Add(new Message
            {
                Role = "assistant",
                Content = text
            });
        }
    }
}
