namespace Transplant.Document.Internals
{
    internal sealed class XplInteriorNode : IXplNode
    {
        internal XplInteriorLayer Layer { get; set; }
        internal XplInteriorNode? Parent { get; set; }
        internal XplInteriorNode? Previous { get; set; }
        internal XplInteriorNode? Next { get; set; }
        internal IXplNode? FirstChild { get; set; }
        internal IXplNode? LastChild { get; set; }

        IXplDocumentLayer IXplNode.Layer => Layer;
        IXplNode? IXplNode.Parent => Parent;
        IXplNode? IXplNode.Previous => Previous;
        IXplNode? IXplNode.Next => Next;
        IXplNode? IXplNode.FirstChild => FirstChild;
        IXplNode? IXplNode.LastChild => LastChild;
        XplGrapheme? IXplNode.Value => null;
    }
}
