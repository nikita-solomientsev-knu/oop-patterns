namespace AdapterProject {
    
    public class Sender {
        public virtual bool Send(string message, string recipient) {
            Console.WriteLine($"Sent message to {recipient}: {message}");
            return true;
        }
    }

    public class MessageSender: Sender {
        public override bool Send(string message, string recipient) {
            Console.WriteLine("Sent from Message Sender");
            return true;
        }
    }
}
