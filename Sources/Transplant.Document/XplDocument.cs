using Transplant.Document.Node;

namespace Transplant.Document
{
    /// <summary>
    /// Represents a document.
    /// </summary>
    public sealed class XplDocument
    {
        /// <summary>
        /// The root node of the document.
        /// </summary>
        public IXplNode Root { get; internal set; }
    }
}
