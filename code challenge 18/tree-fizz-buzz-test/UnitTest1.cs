using tree_breadth_first.classes;
using tree_fizz_buzz.FizzBuzz;
using Xunit;

namespace tree_fizz_buzz_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestKayTree1()
        {
            FizzBuzzNode FirstNode = new FizzBuzzNode(100);
            K_Ary_Tree MyTree = new K_Ary_Tree(FirstNode);

            FizzBuzzNode child1 = new FizzBuzzNode(2);
            FizzBuzzNode child2 = new FizzBuzzNode(1);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(4);
            FizzBuzzNode child4 = new FizzBuzzNode(20);

            child1.AddChild(child3);
            child1.AddChild(child4);
            FizzBuzzNode child5 = new FizzBuzzNode(3);
            child2.AddChild(child5);
            FizzBuzzNode child6 = new FizzBuzzNode(17);
            FizzBuzzNode child7 = new FizzBuzzNode(15);
            child5.AddChild(child6);
            child5.AddChild(child7);
            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "Buzz", "2", "1", "4", "Buzz", "Fizz", "17", "FizzBuzz" };
            Assert.Equal(MyList, MyExpected);
        }
        [Fact]
        public void TestKayTree2()
        {
            FizzBuzzNode FirstNode = new FizzBuzzNode(101);
            K_Ary_Tree MyTree = new K_Ary_Tree(FirstNode);

            FizzBuzzNode child1 = new FizzBuzzNode(2);
            FizzBuzzNode child2 = new FizzBuzzNode(1);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(4);
            FizzBuzzNode child4 = new FizzBuzzNode(212);

            child1.AddChild(child3);
            child1.AddChild(child4);


            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "101", "2", "1", "4", "212", };
            Assert.Equal(MyList, MyExpected);
        }

        [Fact]
        public void testKayTree3()
        {
            FizzBuzzNode firstnode = new FizzBuzzNode(43);
            K_Ary_Tree MyTree = new K_Ary_Tree(firstnode);

            FizzBuzzNode child1 = new FizzBuzzNode(5);
            FizzBuzzNode child2 = new FizzBuzzNode(3);
            MyTree.Root.AddChild(child1);
            MyTree.Root.AddChild(child2);
            FizzBuzzNode child3 = new FizzBuzzNode(87);
            FizzBuzzNode child4 = new FizzBuzzNode(9);

            child1.AddChild(child3);
            child1.AddChild(child4);
            FizzBuzzNode child5 = new FizzBuzzNode(345);
            child2.AddChild(child5);
            FizzBuzzNode child6 = new FizzBuzzNode(97);
            FizzBuzzNode child7 = new FizzBuzzNode(5);
            child5.AddChild(child6);
            child5.AddChild(child7);
            List<string> MyList = new List<string>();
            MyList = MyTree.FizzBuzzTreeMethod(MyTree);
            List<string> MyExpected = new List<string>() { "43", "Buzz", "Fizz", "Fizz", "Fizz", "FizzBuzz", "97", "Buzz" };
            Assert.Equal(MyList, MyExpected);
        }


    }
}