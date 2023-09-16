using Hashtable.Hashtable;

namespace Hashtable.Classes
{
    public class TestHashTable : Hashtable_class
    {
        public TestHashTable(int size) : base(size) { }

        public int TestGetArrayPosition(string key)
        {
            return GetArrayPosition(key);
        }
    }
}
