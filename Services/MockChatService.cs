using System.Linq;
using LLMChatbot.Core;

namespace LLMChatbot.Services
{
    public class MockChatService : IChatService
    {
        public string GetReply(ChatSession session)
        {
            string last = session.Messages.Last().Content.ToLower();

            if (last.Contains("merhaba") || last.Contains("selam"))
                return "Merhaba! Sana nasıl yardımcı olabilirim?";

            if ((last.Contains("türkiye") || last.Contains("turkiye")) && last.Contains("başkent"))
                return "Türkiye'nin başkenti Ankara'dır.";

            if (last.Contains("ntp"))
                return "Nesne Tabanlı Programlama, yazılımda sınıflar ve nesnelerle çalışmayı esas alır.";

            if (last.Contains("nedir") || last.Contains("neresi") || last.Contains("kimdir"))
                return "Bu konuda sana yardımcı olabilmem için biraz daha net bilgi verebilir misin?";

            if (session.Messages.Count > 1)
            {
                var prev = session.Messages[^2].Content.ToLower();
                if (prev.Contains("nedir") || prev.Contains("başkent"))
                    return "Anladım, konuyu açtın. Devam etmek ister misin?";
            }

            return "Bu konu hakkında sınırlı bilgiye sahibim ama mimari olarak geliştirilebilir durumdayım 🙂";
        }
    }
}
