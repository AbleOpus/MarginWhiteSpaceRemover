using System;

namespace MarginWhiteSpaceRemover
{
    /// <summary>
    /// Specifies the kinds of whitespace that exist in text.
    /// </summary>
    [Flags]
    enum WhiteSpacePresence
    {
        /// <summary>
        /// No white space exists.
        /// </summary>
        None = 0,
        /// <summary>
        /// Tab whitespace is present.
        /// </summary>
        Tab = 1,
        /// <summary>
        /// Space whitespace is present.
        /// </summary>
        Space = 2,
        /// <summary>
        /// Both tab and space whitespace are present.
        /// </summary>
        Both = Tab + Space
    }

    /// <summary>
    /// Specifies the various types of whitespace.
    /// </summary>
    enum WhiteSpaceKind
    {
        /// <summary>
        /// A tab character (\t).
        /// </summary>
        Tab = '\t',
        /// <summary>
        /// A space character ( ).
        /// </summary>
        Space = ' ',
    }
}
