using Hashtable.Hashtable;

public class HashtableTests
{
    [Fact]
    public void TestLeftJoin()
    {
        // Create two hashmaps
        Hashtable_class synonyms = new Hashtable_class(10);
        synonyms.Set("diligent", "employed");
        synonyms.Set("fond", "enamored");
        synonyms.Set("guide", "usher");
        synonyms.Set("outfit", "garb");
        synonyms.Set("wrath", "anger");

        Hashtable_class antonyms = new Hashtable_class(10);
        antonyms.Set("diligent", "idle");
        antonyms.Set("fond", "averse");
        antonyms.Set("guide", "follow");
        antonyms.Set("flow", "jam");
        antonyms.Set("wrath", "delight");

        // Call the LeftJoin method
        List<List<string>> result = Hashtable_class.LeftJoin(synonyms, antonyms);

        // Assert the expected result
        Assert.Equal(synonyms.Keys().Count, result.Count);

        foreach (List<string> row in result)
        {
            string key = row[0];
            string synonymValue = synonyms.Get(key);
            string antonymValue = antonyms.Get(key) ?? "NULL";

            Assert.Equal(new List<string> { key, synonymValue, antonymValue }, row);
        }
    }
}
