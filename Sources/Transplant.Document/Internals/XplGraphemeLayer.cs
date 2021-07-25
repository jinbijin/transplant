namespace Transplant.Document.Internals
{
    internal sealed class XplGraphemeLayer : IXplDocumentLayer
    {
        internal XplInteriorLayer? Above { get; set; }
        internal XplGraphemeNode? First { get; set; }
        internal XplGraphemeNode? Last { get; set; }

        IXplNode? IXplDocumentLayer.First => First;
        IXplNode? IXplDocumentLayer.Last => Last;
        IXplDocumentLayer? IXplDocumentLayer.Above => Above;
        IXplDocumentLayer? IXplDocumentLayer.Below => null;
    }
}
