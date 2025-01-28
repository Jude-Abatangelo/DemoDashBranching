namespace TestProject1Demo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    [Fact]
        public void FalseIsFalse()
        {
            //thus was stupid
            Assert.False(false);
            Assert.True(false);
        }
}
