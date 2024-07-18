public class PlainText(string text) : TextComponent
{
    private readonly string _text = text;

    public override string GetText()
    {
        return _text;
    }
}