namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void checkSumOfTwoNumbers()
        {
            //arrange
            int arg1 = 8;
            int arg2 = 2;

            //act
            int result = arg1 + arg2;

            //assert
            Assert.AreEqual(10, result);
        }
    }
}