namespace Hashtable.Hashtable
{
    public class Hashtable_class
    {
        private LinkedList<KeyValuePair<string, string>>[] hashItems;

        public Hashtable_class(int size)
        {
            hashItems = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public void Set(string key, string value)
        {
            int hashedKey = GetArrayPosition(key);

            if (hashItems[hashedKey] == null)
            {
                hashItems[hashedKey] = new LinkedList<KeyValuePair<string, string>>();
            }

            hashItems[hashedKey].AddLast(new KeyValuePair<string, string>(key, value));
        }

        public string Get(string key)
        {
            int hashedKey = GetArrayPosition(key);
            LinkedList<KeyValuePair<string, string>> LinkedList = GetLinkedList(hashedKey);
            foreach (KeyValuePair<string, string> keyValuePair in LinkedList)
            {
                if (keyValuePair.Key == key)
                {
                    return keyValuePair.Value;
                }
            }
            return null;
        }

        public bool Has(string key)
        {
            int hashedKey = GetArrayPosition(key);
            LinkedList<KeyValuePair<string, string>> LinkedList = GetLinkedList(hashedKey);
            foreach (KeyValuePair<string, string> keyValuePair in LinkedList)
            {
                if (keyValuePair.Key == key)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();
            for (int i = 0; i < hashItems.Length; i++)
            {
                if (hashItems[i] != null)
                {
                    LinkedList<KeyValuePair<string, string>> pairs = hashItems[i];
                    foreach (var item in pairs)
                    {
                        keys.Add(item.Key);
                    }
                }
            }
            return keys;
        }

        protected int GetArrayPosition(string key)
        {
            int pos = key.GetHashCode() % hashItems.Length;
            return Math.Abs(pos);
        }

        public LinkedList<KeyValuePair<string, string>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<string, string>> linkedList = hashItems[position];

            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<string, string>>();
                hashItems[position] = linkedList;
            }
            return linkedList;
        }

        public static List<List<string>> LeftJoin(Hashtable_class synonyms, Hashtable_class antonyms)
        {
            List<List<string>> result = new List<List<string>>();

            foreach (string key in synonyms.Keys())
            {
                string synonymValue = synonyms.Get(key);
                string antonymValue = antonyms.Get(key);

                List<string> row = new List<string>
        {
            key,
            synonymValue,
            antonymValue ?? "NULL"
        };

                result.Add(row);
            }

            return result;
        }

    }

}
