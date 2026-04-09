namespace CommandProject.Tests;

using CommandProject;

public class TestEditor {
    
    [Fact]
    public void TestText() {
        TextEditor editor = new TextEditor();
        EditorInvoker invoker = new EditorInvoker();

        invoker.ExecuteCommand(new InsertCommand(editor, "Hello "));
        invoker.ExecuteCommand(new InsertCommand(editor, "World"));
        
        Assert.Equal("Hello World", editor.Text);
        Console.WriteLine(editor.Text);

        invoker.ExecuteCommand(new DeleteCommand(editor, 5));
        
        Assert.Equal("Hello", editor.Text);
        Console.WriteLine(editor.Text);

        invoker.Undo();
        Assert.Equal("Hello World", editor.Text);
        Console.WriteLine(editor.Text);

        invoker.Undo();
        Assert.Equal("Hello", editor.Text);
        Console.WriteLine(editor.Text);
    }
}