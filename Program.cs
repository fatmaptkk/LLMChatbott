using System;
using LLMChatbot.Core;
using LLMChatbot.Services;

namespace LLMChatbot
{
    class Program
    {
        static void Main()
        {
            IChatService chatService = new MockChatService();
            ChatSession session = new ChatSession();

            Console.WriteLine("LLM Chatbot (Mock - API'siz)");
            Console.WriteLine("Çıkmak için 'exit' yaz.\n");

            while (true)
            {
                Console.Write("Sen: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                session.AddUserMessage(input);

                string reply = chatService.GetReply(session);
                session.AddBotMessage(reply);

                Console.WriteLine("Bot: " + reply);
                Console.WriteLine();
            }
        }
    }
}
