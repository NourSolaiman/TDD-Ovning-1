using Skottår_Kalkylator;

namespace Skottår_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        [Test]
        public void IsLeap_ThrowsNotImplementedException()
        {
            // Arrange
            int årAttKontrollera = 2024;

            // Act and Assert
            Assert.Throws<NotImplementedException>(() => År.ÄrSkottår(årAttKontrollera));
        }
        */
        [Test]
        public void När_ÅrÄrDelbartMed400_ShouldReturnTrue()
        {
            // Arrange
            int år = 2000;

            // Act
            bool result = År.ÄrSkottår(år);

            // Assert
            Assert.IsTrue(result);

        }
        [Test]
        public void DelbartMed100MenInteMed400_ÄrSkottår_RetunerarFalse()
        {
            // Arrange
            int år = 1700;

            // Act
            bool result = År.ÄrSkottår(år);

            // Output
            Console.WriteLine(result);

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void DelbartMed4MenInteMed100_ÄrSkottår_RetunerarTrue()
        {
            // Arrange
            int år = 2008;

            // Act
            bool result = År.ÄrSkottår(år);

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void InteÄrDelbartMed4_ÄrSkottår_RetunerarTrue()
        {
            // Arrange
            int år = 2017;

            // Act
            bool result = År.ÄrSkottår(år);

			// Output
			Console.WriteLine(result);

			// Assert
			Assert.IsTrue (result);
        }
    }
}