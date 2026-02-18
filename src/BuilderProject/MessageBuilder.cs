namespace BuilderProject;
using System.Collections.Generic;


public class MessageBuilder {
    private string? _receiver = null, _sender = null, _topic = null, _content = null;
    private List<IAttachment> _attachments;

    public MessageBuilder Receiver(string value) {
        _receiver = value;
        return this;
    }

    public MessageBuilder Sender(string value) {
        _sender = value;
        return this;
    }

    public MessageBuilder Topic(string value) {
        _topic = value;
        return this;
    }

    public MessageBuilder Content(string value) {
        _content = value;
        return this;
    }

    public MessageBuilder NewAttachment(IAttachment value) {
        _attachments.Add(value);
        return this;
    }

    public MessageBuilder RemoveAttachment(IAttachment value) {
        _attachments.Remove(value);
        return this;
    }

    public (bool IsSuccessful, string? Err, Message? Result) Build() {
        if (_receiver == null || _sender == null || _topic == null) {
            return (false, "Sender, Receiver and Topic are required", null);
        }
        if (_content == "" && !_attachments.Any()) {
            return (false, "No attachments and not content are provided", null);
        }
        return (true, null, new Message(_receiver, _sender, _topic, _content, _attachments));
    }
}
