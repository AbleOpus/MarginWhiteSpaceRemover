using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarginWhiteSpaceRemover
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Gets all of the child controls of the control.
        /// </summary>
        /// <param name="control"></param>
        public static IEnumerable<Control> GetAllChildren(this Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(GetAllChildren).Concat(controls);
        }

        /// <summary>
        /// Capitalizes the first letter of the string.
        /// </summary>
        /// <param name="text"></param>
        public static string CapitalizeFirstChar(this string text)
        {
            if (text == string.Empty)
                return text;

            char firstLetter = char.ToUpper(text[0]);
            text = text.Remove(0, 1);
            return firstLetter + text;
        }

        /// <summary>
        /// Removes the specified character from the start of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c">The character to trim off the start of the string.</param>
        /// <param name="count">The max amount of characters to remove. Trims all by default.</param>
        /// <returns>The trimmed string.</returns>
        public static string TrimStart(this string str, char c, int count = int.MaxValue)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("Value must be greater than 0.", nameof(count));

            if (str.Length == 0)
                return str;

            int removed = 0;

            while (str[0] == c)
            {
                str = str.Substring(1, str.Length - 1);
                removed++;

                if (str.Length == 0 || removed == count)
                    break;
            }

            return str;
        }
    }
}
