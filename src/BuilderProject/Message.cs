namespace BuilderProject;
using System.Collections.Generic;


public class Message {
    private string _receiver, _sender, _topic;
    private string? _content;
    private List<IAttachment>? _attachments;

    public Message(string receiver, string sender, string topic, string? content, List<IAttachment>? attachments) {
        _receiver = receiver;
        _sender = sender;
        _topic = topic;
        _content = content;
        _attachments = attachments;
    }

    public (bool IsSuccessful, string? Err) Send() {
        return (true, null);
    }

    public string GetSummary() {
        return $"{_topic} ({_receiver} -> {_sender}) Content length: {_content.Length}, Attechments present? - {_attachments.Any()}";
    }
}
