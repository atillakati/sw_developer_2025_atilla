using NUnit.Framework;

namespace Wifi.PlaylistEditor.BaseTypes.Test
{
    [TestFixture]
    public class PlaylistTests
    {
        private Playlist _fixture;

        [Test]
        public void Test_1()
        {
            //Arrange
            int zahl1 = 5;
            int zahl2 = 15;

            //Act
            var erg = zahl1 + zahl2;

            //Assert
            Assert.That(erg, Is.EqualTo(20));
        }
    }
}
