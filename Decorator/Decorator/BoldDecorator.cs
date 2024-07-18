public class BoldDecorator(TextComponent textComponent) : TextDecorator(textComponent)
{
    public override string GetText()
    {
        return $"<b>{_textComponent.GetText()}</b>";
    }
}