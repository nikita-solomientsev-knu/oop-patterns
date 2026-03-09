namespace AdapterProject {

    public class TelegramSender {
        public string SendTelegram(string message, string username) {
            Console.WriteLine($"Telegram is sent: #{username}: {message}");
            return "Telegram sent";
        }
    }

    public class TelegramSenderAdapter: Sender {
        private readonly TelegramSender _telegramSender = new TelegramSender();

        public override bool Send(string message, string recipient) {
            return _telegramSender.SendTelegram(message, recipient) == "Telegram sent";
        }
    }
}
