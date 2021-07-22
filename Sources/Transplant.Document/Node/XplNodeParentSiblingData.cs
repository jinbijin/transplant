namespace Transplant.Document.Node
{
    internal sealed class XplNodeParentSiblingData
    {
        internal IXplNode Parent { get; set; }
        internal IXplNode? Previous { get; set; }
        internal IXplNode? Next { get; set; }
    }
}
