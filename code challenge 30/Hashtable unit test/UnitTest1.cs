using Hashtable.Classes;
using Hashtable.Hashtable;

public class HashtableTests
{
    [Fact]
    public void Test_SetValue_And_RetrieveValue_From_Hashtable()
    {
        // Arrange
        var hashtable = new Hashtable_class(10);
        hashtable.Set("key1", "value1");

        // Act
        var value = hashtable.Get("key1");

        // Assert
        Assert.Equal("value1", value);
    }

    [Fact]
    public void Test_RetrieveValue_From_NonExistentKey_Returns_Null()
    {
        // Arrange
        var hashtable = new Hashtable_class(10);

        // Act
        var value = hashtable.Get("nonexistentkey");

        // Assert
        Assert.Null(value);
    }

    [Fact]
    public void Test_Retrieve_All_UniqueKeys_From_Hashtable()
    {
        // Arrange
        var hashtable = new Hashtable_class(10);
        hashtable.Set("key1", "value1");
        hashtable.Set("key2", "value2");

        // Act
        List<string> keys = hashtable.Keys();

        // Assert
        Assert.Contains("key1", keys);
        Assert.Contains("key2", keys);
    }

    [Fact]
    public void Test_Handle_Collision_Within_Hashtable()
    {
        // Arrange
        var hashtable = new Hashtable_class(1);  // Force a collision
        hashtable.Set("key1", "value1");
        hashtable.Set("key2", "value2");

        // Act
        var value1 = hashtable.Get("key1");
        var value2 = hashtable.Get("key2");

        // Assert
        Assert.Equal("value1", value1);
        Assert.Equal("value2", value2);
    }

    [Fact]
    public void Test_Retrieve_Value_From_Bucket_With_Collision()
    {
        // Arrange
        var hashtable = new Hashtable_class(1);  // Force a collision
        hashtable.Set("key1", "value1");
        hashtable.Set("key2", "value2");

        // Act
        var value = hashtable.Get("key2");  // Retrieve from collision bucket

        // Assert
        Assert.Equal("value2", value);
    }

    [Fact]
    public void Test_Hash_Key_To_InRange_Value()
    {
        // Arrange
        var size = 10;
        var hashtable = new TestHashTable(size);

        // Act & Assert
        for (int i = 0; i < 100; i++)
        {
            string key = $"key{i}";
            int position = hashtable.TestGetArrayPosition(key);

            // Position should be in range [0, size)
            Assert.InRange(position, 0, size - 1);
        }
    }

}
