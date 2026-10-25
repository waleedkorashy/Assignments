using System;
using System.Collections.Generic;
using System.Text;

namespace Part_1
{
    public class AnagramComparer : IEqualityComparer<string>
    {
        // Two words are equal if their sorted letters match
        public bool Equals(string? x, string? y)
            => Normalize(x) == Normalize(y);

        // Equal words MUST return the same hash code
        public int GetHashCode(string obj)
            => Normalize(obj).GetHashCode();

        private static string Normalize(string? word)
        {
            if (word is null) return "";
            var letters = word.Trim().ToCharArray();
            Array.Sort(letters);
            return new string(letters);
        }
    }
}
