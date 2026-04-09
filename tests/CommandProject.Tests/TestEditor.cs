namespace CommandProject.Tests;

public class TestEditor {
    
    [Fact]
    public void TestText() {
        TextEditor editor = new TextEditor();
        EditorInvoker invoker = new EditorInvoker();

        invoker.ExecuteCommand(new InsertCommand(editor, "Hello "));
        invoker.ExecuteCommand(new InsertCommand(editor, "World"));
        
        Assert.Equal(editor.Text, "Hello World");
        Console.WriteLine(editor.Text);

        invoker.ExecuteCommand(new DeleteCommand(editor, 5));
        
        Assert.Equal(editor.Text, "Hello");
        Console.WriteLine(editor.Text);

        invoker.Undo();
        Assert.Equal(editor.Text, "Hello World");
        Console.WriteLine(editor.Text);

        invoker.Undo();
        Assert.Equal(editor.Text, "Hello");
        Console.WriteLine(editor.Text);
    }
}