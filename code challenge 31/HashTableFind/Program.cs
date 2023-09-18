using System.Text;

namespace HashTableFind
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class CustomHashTable<TKey, TValue>
    {
        public int size;
        public List<KeyValuePair<TKey, TValue>>[] buckets;

        public CustomHashTable(int size)
        {
            this.size = size;
            this.buckets = new List<KeyValuePair<TKey, TValue>>[size];
        }

        public string FindFirstRepeatedWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string is empty or null.");
            }

            List<string> words = SplitStringIntoWords(input);

            var wordFrequencyTable = new CustomHashTable<string, int>(words.Count);

            foreach (string word in words)
            {
                string lowercaseWord = word.ToLower();

                if (wordFrequencyTable.ContainsKey(lowercaseWord))
                {
                    return word;
                }

                wordFrequencyTable.Add(lowercaseWord, 1);
            }

            return null;
        }

        private List<string> SplitStringIntoWords(string input)
        {
            List<string> words = new List<string>();
            StringBuilder currentWord = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || IsPunctuation(c))
                {
                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }
                }
                else
                {
                    currentWord.Append(c);
                }
            }

            if (currentWord.Length > 0)
            {
                words.Add(currentWord.ToString());
            }

            return words;
        }

        private bool IsPunctuation(char c)
        {
            char[] punctuationChars = { '.', ',', ';', '!', '?' };
            return Array.IndexOf(punctuationChars, c) != -1;
        }

        public int GetHash(TKey key)
        {
            int hashCode = key.GetHashCode();
            if (hashCode < 0)
            {
                hashCode = Math.Abs(hashCode);
            }
            return hashCode % size;
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetHash(key);
            if (buckets[index] == null)
            {
                buckets[index] = new List<KeyValuePair<TKey, TValue>>();
            }

            for (int i = 0; i < buckets[index].Count; i++)
            {
                if (buckets[index][i].Key.Equals(key))
                {
                    buckets[index][i] = new KeyValuePair<TKey, TValue>(key, value);
                    return;
                }
            }

            buckets[index].Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            int index = GetHash(key);
            if (buckets[index] != null)
            {
                foreach (var kvp in buckets[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        value = kvp.Value;
                        return true;
                    }
                }
            }

            value = default(TValue);
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            int index = GetHash(key);
            if (buckets[index] != null)
            {
                foreach (var kvp in buckets[index])
                {
                    if (kvp.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            var keys = new List<TKey>();
            foreach (var bucket in buckets)
            {
                if (bucket != null)
                {
                    foreach (var kvp in bucket)
                    {
                        keys.Add(kvp.Key);
                    }
                }
            }
            return keys;
        }

        public int Hash(TKey key)
        {
            return GetHash(key);
        }
    }
}