public abstract class TextDecorator(TextComponent textComponent) : TextComponent
{
    protected TextComponent _textComponent = textComponent;

    public override string GetText()
    {
        return _textComponent.GetText();
    }
}