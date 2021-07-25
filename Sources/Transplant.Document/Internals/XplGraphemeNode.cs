namespace Transplant.Document.Internals
{
    internal sealed class XplGraphemeNode : IXplNode
    {
        internal XplGraphemeLayer Layer { get; set; }

        internal XplInteriorNode Parent { get; set; }
        internal XplGraphemeNode? Previous { get; set; }
        internal XplGraphemeNode? Next { get; set; }
        internal XplGrapheme Value { get; set; }

        IXplDocumentLayer IXplNode.Layer => Layer;
        IXplNode? IXplNode.Parent => Parent;
        IXplNode? IXplNode.Previous => Previous;
        IXplNode? IXplNode.Next => Next;
        IXplNode? IXplNode.FirstChild => null;
        IXplNode? IXplNode.LastChild => null;
        XplGrapheme? IXplNode.Value => Value;
    }
}
