namespace Transplant.Document.Node
{
    internal sealed class XplNode : IXplNode
    {
        internal XplNodeParentSiblingData? ParentData { get; set; }
        internal XplNodeChildData ChildData { get; set; }

        IXplNode? IXplNode.Parent => ParentData?.Parent;
        IXplNode? IXplNode.Previous => ParentData?.Previous;
        IXplNode? IXplNode.Next => ParentData?.Next;
        IXplNode? IXplNode.FirstChild => ChildData?.FirstChild;
        IXplNode? IXplNode.LastChild => ChildData?.LastChild;
        Grapheme? IXplNode.Value => null;
    }
}
