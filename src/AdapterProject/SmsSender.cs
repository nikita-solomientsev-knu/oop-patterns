namespace AdapterProject {

    public class SmsSender {
        public string SendSms(string recipient, string message) {
            Console.WriteLine($"Sms is sent: {recipient} <- {message}");
            return "Success";
        }
    }

    public class SmsSenderAdapter: Sender {
        private readonly SmsSender _smsSender = new SmsSender();

        public override bool Send(string message, string recipient) {
            return _smsSender.SendSms(recipient, message) == "Success";
        }
    }
}
