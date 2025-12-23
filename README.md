# LLM Chatbot (Mock Version)

Bu proje, Yazılım Mühendisliği 2. sınıf **Nesne Tabanlı Programlama (NTP)** dersi kapsamında
geliştirilmiş, **LLM (Large Language Model) tabanlı sohbet sistemlerinin mimarisini**
simüle eden bir **C# Console Application** projesidir.

Projede gerçek bir LLM servisi yerine **Mock (sahte) LLM servisi** kullanılmıştır.
Ama mimari yapı, gerçek bir LLM API entegrasyonuna hazır olacak şekilde tasarlanmıştır.

---

## 🚀 Özellikler

- API kullanılmadan çalışan chatbot
- Nesne tabanlı ve katmanlı mimari
- Interface (arayüz) kullanımı
- Sohbet geçmişi yönetimi
- Genişletilebilir yapı (gerçek LLM entegrasyonu eklenebilir)

---

## 🧱 Kullanılan Teknolojiler

- C#
- .NET Console Application
- Nesne Tabanlı Programlama (OOP / NTP)
- Git & GitHub

---

## 🧠 Mimari Yapı

Projede aşağıdaki sınıflar bulunmaktadır:

- **Message**  
  Kullanıcı ve bot mesajlarını temsil eden model sınıfı.

- **ChatSession**  
  Sohbet geçmişini yöneten sınıf.

- **IChatService**  
  Chatbot servisleri için arayüz (interface).

- **MockChatService**  
  LLM davranışını simüle eden mock servis.

- **Program**  
  Uygulamanın giriş noktası.

Bu yapı sayesinde gerçek bir LLM servisi, mevcut mimari değiştirilmeden projeye entegre edilebilir.

---

## ▶️ Nasıl Çalıştırılır?

1. Projeyi Visual Studio ile açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsol üzerinden chatbot ile etkileşime geçin.
4. Çıkmak için `exit` yazın.

---

## 📌 Not

Bu proje gerçek bir yapay zeka modeli içermez.
Ama **LLM tabanlı sistemlerin yazılım mimarisini** doğru şekilde modellemektedir.
