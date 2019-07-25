using Xunit;

namespace Hello_CircleCI.Test
{
    public class ProgramTest
    {

        [Fact]
        public void Pass()
        {
            Assert.Equal(0, Program.Main(null));
        }

        [Fact]
        public void Fail()
        {
            Assert.Equal(1 ,Program.Main(null));
        }
        
    }
}