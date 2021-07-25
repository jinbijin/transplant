namespace Transplant.Document.Internals
{
    internal sealed class XplInteriorLayer : IXplDocumentLayer
    {
        internal XplInteriorLayer? Above { get; set; }
        internal IXplDocumentLayer Below { get; set; }
        internal XplInteriorNode? First { get; set; }
        internal XplInteriorNode? Last { get; set; }

        IXplNode? IXplDocumentLayer.First => First;
        IXplNode? IXplDocumentLayer.Last => Last;
        IXplDocumentLayer? IXplDocumentLayer.Above => Above;
        IXplDocumentLayer? IXplDocumentLayer.Below => Below;
    }
}
