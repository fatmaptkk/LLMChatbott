using LLMChatbot.Core;

namespace LLMChatbot.Services
{
    public interface IChatService
    {
        string GetReply(ChatSession session);
    }
}
