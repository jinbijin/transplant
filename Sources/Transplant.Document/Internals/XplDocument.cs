namespace Transplant.Document.Internals
{
    internal sealed class XplDocument : IXplDocument
    {
        internal XplInteriorNode Root { get; init; }
        internal XplGraphemeLayer Bottom { get; init; }
        internal IXplDocumentLayer Top { get; init; }

        IXplNode IXplDocument.Root => Root;
        IXplDocumentLayer IXplDocument.Bottom => Bottom;
        IXplDocumentLayer IXplDocument.Top => Top;
    }
}
