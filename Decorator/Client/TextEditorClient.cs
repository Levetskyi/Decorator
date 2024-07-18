public class TextEditorClient
{
    public void Main()
    {
        TextComponent text = new PlainText("Hello, World!");
        Console.WriteLine($"Plain Text: {text.GetText()}");

        text = new BoldDecorator(text);
        Console.WriteLine($"Bold Text: {text.GetText()}");

        text = new ItalicDecorator(text);
        Console.WriteLine($"Bold and Italic Text: {text.GetText()}");

        text = new UnderlineDecorator(text);
        Console.WriteLine($"Bold, Italic, and Underline Text: {text.GetText()}");
    }
}