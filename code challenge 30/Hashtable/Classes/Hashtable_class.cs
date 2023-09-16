namespace Hashtable.Hashtable
{
    public class Hashtable_class
    {
        private LinkedList<KeyValuePair<string, string>>[] items;

        public Hashtable_class(int size)
        {
            items = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public void Set(string key, string value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<string, string>> linkedList = GetLinkedList(position);
            var item = new KeyValuePair<string, string>(key, value);
            linkedList.AddLast(item);
        }

        public string Get(string key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<string, string>> linkedList = GetLinkedList(position);
            foreach (KeyValuePair<string, string> pair in linkedList)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            return null;
        }

        public bool Has(string key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<string, string>> linkedList = GetLinkedList(position);
            foreach (KeyValuePair<string, string> pair in linkedList)
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    LinkedList<KeyValuePair<string, string>> linkedList = items[i];
                    foreach (KeyValuePair<string, string> pair in linkedList)
                    {
                        keys.Add(pair.Key);
                    }
                }
            }

            return keys;
        }

        protected int GetArrayPosition(string key)
        {
            int position = key.GetHashCode() % items.Length;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValuePair<string, string>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<string, string>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<string, string>>();
                items[position] = linkedList;
            }

            return linkedList;
        }
    }

}
