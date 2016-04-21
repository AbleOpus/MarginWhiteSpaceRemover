using System;
using System.Text;
using System.Threading.Tasks;

namespace MarginWhiteSpaceRemover
{
    /// <summary>
    /// Provides functionality for removing and analyzing white space at the beginning of text lines.
    /// The space that is common at the start of every line in an array is the left white-space margin.
    /// </summary>
    static class WhiteSpaceMagic
    {
        /// <summary>
        /// Gets the whitespace potentially in the left margin, replaces tabs with spaces, and removes
        /// the left margin whitespace asynchronously.
        /// </summary>
        /// <param name="lines">The lines to be processed.</param>
        /// <param name="tabSize">The amount of spaces to replace tabs with. Specify -1 to skip tab replacing.</param>
        /// <returns>A Task that yields the results of the string operations.</returns>
        public static Task<ProcessLinesResults> ProcessLinesTaskAsync(string[] lines, int tabSize)
        {
            if (tabSize < -1)
                throw new ArgumentOutOfRangeException(nameof(tabSize), "Value must be greater than or equal to -1.");

            return Task.Run(() =>
            {
                var marginKind = GetMarginKind(lines);
                string[] resultLines = (string[])lines.Clone();

                if (tabSize != -1)
                    resultLines = ReplaceTabsWithSpaces(resultLines, tabSize);

                resultLines = RemoveLeftMargin(resultLines, WhiteSpaceKind.Space);
                return new ProcessLinesResults(resultLines, marginKind);
            });
        }

        /// <summary>
        /// Replaces tab characters with the specified amount of spaces.
        /// </summary>
        /// <param name="lines">The text lines to process.</param>
        /// <param name="spaceCount">How many spaces to insert.</param>
        /// <returns>The processed lines as a new string array.</returns>
        public static string[] ReplaceTabsWithSpaces(string[] lines, int spaceCount)
        {
            if (spaceCount < 0)
                throw new ArgumentOutOfRangeException("Value cannot be less than 0.", nameof(spaceCount));

            if (lines == null)
                throw new ArgumentNullException(nameof(lines));

            string spaces = GenerateSpaces(spaceCount);
            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
                newLines[i] = lines[i].Replace("\t", spaces);

            return newLines;
        }

        /// <summary>
        /// Generates the specified amount of space characters.
        /// </summary>
        /// <param name="count">The space character count.</param>
        public static string GenerateSpaces(int count)
        {
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                SB.Append(' ');
            }

            return SB.ToString();
        }

        /// <summary>
        /// Removes the specified whitespace left margin from the specified lines.
        /// </summary>
        /// <param name="lines">The lines to process.</param>
        /// <param name="kind">The kind of whitespace to trim.</param>
        /// <returns>A new set of lines with whitespace trimmed.</returns>
        public static string[] RemoveLeftMargin(string[] lines, WhiteSpaceKind kind)
        {
            if (lines.Length == 0)
                return lines;

            char spaceChar = (char)kind;
            // Get shortest white space.
            int shortest = int.MaxValue;

            foreach (var line in lines)
            {
                int count = GetCharacterStartCount(line, spaceChar);

                if (count < shortest && count != -1)
                    shortest = count;
            }

            if (shortest == int.MaxValue || shortest == 0)
                return lines;

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != null)
                    newLines[i] = lines[i].TrimStart(spaceChar, shortest);
            }

            return newLines;
        }

        /// <summary>
        /// Gets how many occurrences of the specified character exist in a sequence at
        /// the start of the specified string.
        /// </summary>
        /// <param name="line">The line to analyze.</param>
        /// <param name="c">The character to look for.</param>
        public static int GetCharacterStartCount(string line, char c)
        {
            if (String.IsNullOrWhiteSpace(line))
                return -1;

            int count = 0;

            foreach (char d in line)
            {
                if (d == c) count++;
                else break;
            }

            return count;
        }

        /// <summary>
        /// Gets the kind of whitespace that can potentially be within the whitespace margin.
        /// </summary>
        /// <param name="lines">The text lines to analyze.</param>
        public static WhiteSpacePresence GetMarginKind(string[] lines)
        {
            WhiteSpacePresence presence = WhiteSpacePresence.None;

            foreach (var line in lines)
            {
                if (line == null) continue;

                foreach (char c in line)
                {
                    switch (c)
                    {
                        case '\t': presence |= WhiteSpacePresence.Tab; break;
                        case ' ': presence |= WhiteSpacePresence.Space; break;
                        default: continue;
                    }
                }
            }

            return presence;
        }
    }
}
