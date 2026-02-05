using Moq;
using NUnit.Framework;

namespace Wifi.PlaylistEditor.BaseTypes.Test
{
    [TestFixture]
    public class PlaylistTests
    {
        private IPlaylist _fixture;
        private Mock<IPlaylistItem> _mockedItem1;
        private Mock<IPlaylistItem> _mockedItem2;

        [SetUp]
        public void Init()
        {
            _fixture = new Playlist("Demo", "DJ Gandalf");

            _mockedItem1 = new Mock<IPlaylistItem>();
            _mockedItem1.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(50));

            _mockedItem2 = new Mock<IPlaylistItem>();
            _mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(25));
        }

        [Test]
        public void Remove()
        {
            //arrange                                       
            _fixture.Add(_mockedItem1.Object);
            var existingItemCount = _fixture.Items.Count();

            //act
            _fixture.Remove(_mockedItem1.Object);

            //assert
            Assert.That(existingItemCount, Is.EqualTo(1));
            Assert.That(_fixture.Items.Count(), Is.EqualTo(0));
        }

        [Test]
        public void Add()
        {
            //arrange            
            var existingItemCount = _fixture.Items.Count();

            //act
            _fixture.Add(_mockedItem1.Object);

            //assert
            Assert.That(existingItemCount, Is.EqualTo(0));
            Assert.That(_fixture.Items.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Clear()
        {
            //arrange
            _fixture.Add(_mockedItem2.Object);
            _fixture.Add(_mockedItem1.Object);
            var existingItemCount = _fixture.Items.Count();

            //act
            _fixture.Clear();

            //assert
            Assert.That(existingItemCount, Is.EqualTo(2));
            Assert.That(_fixture.Items.Count(), Is.Zero);
        }

        [Test]
        public void Duration_Read()
        {
            //arrange
            _fixture.Add(_mockedItem1.Object);
            _fixture.Add(_mockedItem2.Object);

            //act
            var result = _fixture.Duration;

            //assert
            Assert.That(result, Is.EqualTo(TimeSpan.FromSeconds(75)));
        }

        [Test]
        public void Title_Read()
        {
            //arrange

            //act
            var result = _fixture.Title;

            //assert
            Assert.That(result, Is.EqualTo("Demo"));
        }

        [Test]
        public void Author_Read()
        {
            //arrange            

            //act
            var result = _fixture.Author;

            //assert
            Assert.That(result, Is.EqualTo("DJ Gandalf"));
        }



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

        [Test]
        public void Test_2()
        {
            //Arrange
            int zahl1 = 5;
            int zahl2 = 15;

            //Act
            var erg = zahl1 - zahl2;

            //Assert
            Assert.That(erg, Is.EqualTo(-10));
        }
    }
}
