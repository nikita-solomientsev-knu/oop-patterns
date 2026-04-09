

using System;
using System.Collections.Generic;

// Receiver
namespace CommandProject {
    class TextEditor {
        public string Text { get; private set; } = "";

        public void Insert(string text) {
            Text += text;
        }

        public void Delete(int length) {
            if (length > Text.Length)
                length = Text.Length;

            Text = Text.Substring(0, Text.Length - length);
        }
    }

    interface ICommand {
        void Execute();
        void Undo();
    }

    class InsertCommand : ICommand {
        private TextEditor _editor;
        private string _text;

        public InsertCommand(TextEditor editor, string text) {
            _editor = editor;
            _text = text;
        }

        public void Execute() {
            _editor.Insert(text);
        }

        public void Undo() {
            _editor.Delete(text.Length);
        }
    }

    class DeleteCommand : ICommand
    {
        private TextEditor _editor;
        private string _deletedText;

        public DeleteCommand(TextEditor editor, int length) {
            _editor = editor;

            int start = Math.Max(0, editor.Text.Length - length);
            _deletedText = editor.Text.Substring(start);
        }

        public void Execute() {
            _editor.Delete(_deletedText.Length);
        }

        public void Undo() {
            _editor.Insert(_deletedText);
        }
    }

    class EditorInvoker
    {
        private Stack<ICommand> _history = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command) {
            command.Execute();
            _history.Push(command);
        }

        public void Undo() {
            if (history.Count > 0)
            {
                ICommand command = history.Pop();
                command.Undo();
            }
        }
    }
}
