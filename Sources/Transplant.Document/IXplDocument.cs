namespace Transplant.Document
{
    /// <summary>
    /// Represents a document.
    /// </summary>
    public interface IXplDocument
    {
        /// <summary>
        /// The root node of the document.
        /// </summary>
        IXplNode Root { get; }

        /// <summary>
        /// The bottom layer of the document.
        /// </summary>
        IXplDocumentLayer Bottom { get; }

        /// <summary>
        /// The top layer of the document.
        /// </summary>
        IXplDocumentLayer Top { get; }
    }
}
