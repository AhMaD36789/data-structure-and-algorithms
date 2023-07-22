using Xunit;

namespace stack_queue_brackets_unit_test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void TrueTestCasesBracketValidate(string input)
        {
            Stack stack = new Stack();
            Assert.True(stack.ValidateBrackets(input));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void FalseTestCasesBracketValidate(string input)
        {
            Stack stack = new Stack();
            Assert.False(stack.ValidateBrackets(input));
        }

    }
}