using System.Diagnostics.CodeAnalysis;

namespace Transplant.Document
{
    /// <summary>
    /// Represents a node in a document.
    /// </summary>
    public interface IXplNode
    {
        /// <summary>
        /// The parent layer of the node.
        /// </summary>
        IXplDocumentLayer Layer { get; }

        /// <summary>
        /// The parent of the node, if it exists.
        /// </summary>
        IXplNode? Parent { get; }

        /// <summary>
        /// The previous node in its layer, if it exists.
        /// </summary>
        IXplNode? Previous { get; }

        /// <summary>
        /// The next node in its layer, if it exists.
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
        XplGrapheme? Value { get; }

        /// <summary>
        /// Whether the node is the root of a document.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Parent))]
        bool IsRoot => Parent == null;

        /// <summary>
        /// Whether the node is an interior node.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Value))]
        [MemberNotNullWhen(true, nameof(FirstChild), nameof(LastChild))]
        bool IsInterior => Value == null;

        /// <summary>
        /// Whether the node is a leaf.
        /// </summary>
        [MemberNotNullWhen(true, nameof(Value))]
        [MemberNotNullWhen(false, nameof(FirstChild), nameof(LastChild))]
        bool IsLeaf => !IsInterior;

        /// <summary>
        /// Whether the node is the first in its layer.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Previous))]
        bool IsFirst => Previous == null;

        /// <summary>
        /// Whether the node is the last in its layer.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Next))]
        bool IsLast => Next == null;

        /// <summary>
        /// Whether the node is the only one in its layer.
        /// </summary>
        [MemberNotNullWhen(false, nameof(Previous), nameof(Next))]
        bool IsSingle => IsFirst && IsLast;
    }
}
