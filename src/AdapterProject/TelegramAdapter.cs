namespace AdapterProject {

    public class TelegramSender {
        public string SendTelegram(int userId, string username, string message) {
            Console.WriteLine($"Telegram is sent: #{userId} {username}: {message}");
            return "Telegram sent";
        }
    }

    public class TelegramSenderAdapter: Sender {
        private readonly TelegramSender _telegramSender = new TelegramSender();

        public override bool Send(string message, string recipient) {
            return _telegramSender.SendTelegram(0, recipient, message) == "Telegram sent";
        }
    }
}
