using System.Diagnostics.CodeAnalysis;

namespace Transplant.Document
{
    /// <summary>
    /// Represents a layer of the tree structure of a document.
    /// </summary>
    public interface IXplDocumentLayer
    {
        /// <summary>
        /// The layer directly above the current one.
        /// </summary>
        IXplDocumentLayer? Above { get; }

        /// <summary>
        /// The layer directly below the current one.
        /// </summary>
        IXplDocumentLayer? Below { get; }

        /// <summary>
        /// The first top-level node in the layer.
        /// </summary>
        IXplNode? First { get; }

        /// <summary>
        /// The last top-level node in the layer.
        /// </summary>
        IXplNode? Last { get; }

        /// <summary>
        /// Whether the layer is empty.
        /// </summary>
        [MemberNotNullWhen(false, nameof(First), nameof(Last))]
        bool IsEmpty => First == null && Last == null;

        /// <summary>
        /// Whether the layer is the top layer.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Above))]
        bool IsTopLayer => Above == null;

        /// <summary>
        /// Whether the layer is the bottom layer.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Below))]
        bool IsBottomLayer => Below == null;
    }
}
