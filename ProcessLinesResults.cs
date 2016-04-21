using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarginWhiteSpaceRemover
{
    /// <summary>
    /// Represents the results yeilded by the ProcessLines method.
    /// </summary>
    class ProcessLinesResults
    {
        /// <summary>
        /// Gets the lines after they have been processed.
        /// </summary>
        public string[] Lines { get; }

        /// <summary>
        /// Gets what whitespace was present in the lines.
        /// </summary>
        public WhiteSpacePresence WhiteSpacePresence { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessLinesResults"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="lines">The lines after they have been processed.</param>
        /// <param name="whiteSpacePresence">What whitespace was present in the lines.</param>
        public ProcessLinesResults(string[] lines, WhiteSpacePresence whiteSpacePresence)
        {
            Lines = lines;
            WhiteSpacePresence = whiteSpacePresence;
        }
    }
}
