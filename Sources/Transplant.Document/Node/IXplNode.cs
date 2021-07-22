namespace Transplant.Document.Node
{
    /// <summary>
    /// Represents a node in a document.
    /// </summary>
    public interface IXplNode
    {
        /// <summary>
        /// The parent of the node, if it exists.
        /// </summary>
        IXplNode? Parent { get; }

        /// <summary>
        /// The previous sibling of the node, if it exists.
        /// </summary>
        IXplNode? Previous { get; }

        /// <summary>
        /// The next sibling of the node, if it exists.
        /// </summary>
        IXplNode? Next { get; }

        /// <summary>
        /// The first child of the node, if it exists.
        /// </summary>
        IXplNode? FirstChild { get; }

        /// <summary>
        /// The last child of the node, if it exists.
        /// </summary>
        IXplNode? LastChild { get; }

        /// <summary>
        /// The grapheme content of the node, if it is a leaf.
        /// </summary>
        Grapheme? Value { get; }

        /// <summary>
        /// Whether the node is the root of a document.
        /// </summary>
        bool IsRoot => Parent == null;

        /// <summary>
        /// Whether the node is an interior node.
        /// </summary>
        bool IsInterior => Value == null;

        /// <summary>
        /// Whether the node is a leaf.
        /// </summary>
        bool IsLeaf => !IsInterior;

        /// <summary>
        /// Whether the node is the first of its siblings.
        /// </summary>
        bool IsFirst => Previous == null;

        /// <summary>
        /// Whether the node is the last of its siblings.
        /// </summary>
        bool IsLast => Next == null;

        /// <summary>
        /// Whether the node is the only sibling.
        /// </summary>
        bool IsSingle => IsFirst && IsLast;
    }
}
