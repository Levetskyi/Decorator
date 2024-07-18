public class UnderlineDecorator(TextComponent textComponent) : TextDecorator(textComponent)
{
    public override string GetText()
    {
        return $"<u>{_textComponent.GetText()}</u>";
    }
}