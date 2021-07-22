namespace Transplant.Document.Node
{
    internal sealed class XplLeaf : IXplNode
    {
        internal XplNodeParentSiblingData? ParentData { get; set; }
        internal Grapheme? Value { get; set; } // Can be null if it represents a cursor in insert mode?

        IXplNode? IXplNode.Parent => ParentData?.Parent;
        IXplNode? IXplNode.Previous => ParentData?.Previous;
        IXplNode? IXplNode.Next => ParentData?.Next;
        IXplNode? IXplNode.FirstChild => null;
        IXplNode? IXplNode.LastChild => null;
        Grapheme? IXplNode.Value => Value;
    }
}
