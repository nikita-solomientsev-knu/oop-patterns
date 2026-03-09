namespace AdapterProject {

    public class SmsSender {
        public string SendSms(string message, string phoneNumber) {
            Console.WriteLine($"Sms is sent: {phoneNumber} <- {message}");
            return "Success";
        }
    }

    public class SmsSenderAdapter: Sender {
        private readonly SmsSender _smsSender = new SmsSender();

        public override bool Send(string message, string recipient) {
            return _smsSender.SendSms(message, recipient) == "Success";
        }
    }
}
