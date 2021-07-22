namespace Transplant.Document.Node
{
    public readonly struct Grapheme
    {
        public Grapheme(string value)
        {
            Value = value;
        }

        public readonly string Value { get; }
    }
}
