public class ItalicDecorator(TextComponent textComponent) : TextDecorator(textComponent)
{
    public override string GetText()
    {
        return $"<i>{_textComponent.GetText()}</i>";
    }
}