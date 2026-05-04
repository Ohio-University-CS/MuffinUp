using NUnit.Framework;
using KitchenData;
using KitchenLib.Customs;
using KitchenMuffinUp.Customs.ItemGroups;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the MuffinPlate custom item group class.
    /// Tests the item group identification and group view configuration.
    /// </summary>
    [TestFixture]
    public class MuffinPlateTests
    {
        private MuffinPlate _muffinPlate;

        [SetUp]
        public void SetUp()
        {
            _muffinPlate = new MuffinPlate();
        }

        /// <summary>
        /// Test Case 1: Normal Case - Verify that UniqueNameID is correctly set to "MuffinPlater"
        /// This tests the basic item group identification in the game system.
        /// </summary>
        [Test]
        public void UniqueNameID_ReturnsCorrectIdentifier()
        {
            // Arrange & Act
            string uniqueId = _muffinPlate.UniqueNameID;

            // Assert
            Assert.AreEqual("MuffinPlater", uniqueId,
                "UniqueNameID should return 'MuffinPlater' for proper item group identification");
            Assert.IsFalse(string.IsNullOrEmpty(uniqueId),
                "UniqueNameID should not be null or empty");
        }

        /// <summary>
        /// Test Case 2: Consistency Case - Verify that UniqueNameID returns the same value on multiple calls
        /// Tests that the identifier is consistent across multiple property accesses.
        /// </summary>
        [Test]
        public void UniqueNameID_ConsistencyAcrossMultipleCalls()
        {
            // Arrange & Act
            string firstCall = _muffinPlate.UniqueNameID;
            string secondCall = _muffinPlate.UniqueNameID;
            string thirdCall = _muffinPlate.UniqueNameID;

            // Assert
            Assert.AreEqual(firstCall, secondCall,
                "UniqueNameID should return consistent value on first and second call");
            Assert.AreEqual(secondCall, thirdCall,
                "UniqueNameID should return consistent value on second and third call");
            Assert.AreEqual("MuffinPlater", firstCall,
                "All calls should return the expected identifier");
        }

        /// <summary>
        /// Test Case 3: Inheritance Case - Verify that MuffinPlate extends CustomItemGroup correctly
        /// Tests that the class properly inherits from the CustomItemGroup base class.
        /// </summary>
        [Test]
        public void MuffinPlate_IsValidCustomItemGroup()
        {
            // Arrange & Act
            MuffinPlate plate = new MuffinPlate();

            // Assert - Verify inheritance and type
            Assert.IsInstanceOf<CustomItemGroup<ItemGroupView>>(plate,
                "MuffinPlate should inherit from CustomItemGroup<ItemGroupView>");
            Assert.IsNotNull(plate.UniqueNameID,
                "CustomItemGroup derived class should have a UniqueNameID");
        }

        /// <summary>
        /// Test Case 4: Identity Case - Verify that multiple instances have the same identifier
        /// Tests that different instances maintain consistent item group identification.
        /// </summary>
        [Test]
        public void MultipleInstances_SameIdentifier()
        {
            // Arrange & Act
            MuffinPlate plate1 = new MuffinPlate();
            MuffinPlate plate2 = new MuffinPlate();
            MuffinPlate plate3 = new MuffinPlate();

            // Assert
            Assert.AreEqual(plate1.UniqueNameID, plate2.UniqueNameID,
                "Different instances should have the same UniqueNameID");
            Assert.AreEqual(plate2.UniqueNameID, plate3.UniqueNameID,
                "All instances should maintain consistent identifiers");
            Assert.AreEqual("MuffinPlater", plate1.UniqueNameID,
                "Instance ID should match expected constant");
        }

        /// <summary>
        /// Test Case 5: Naming Validation Case - Verify that the identifier follows naming conventions
        /// Tests that the identifier is properly formatted (contains "Muffin" reference).
        /// </summary>
        [Test]
        public void UniqueNameID_FollowsNamingConvention()
        {
            // Arrange & Act
            string uniqueId = _muffinPlate.UniqueNameID;

            // Assert
            Assert.IsTrue(uniqueId.Contains("Muffin"),
                "UniqueNameID should contain 'Muffin' to relate to the muffin dish");
            Assert.IsTrue(uniqueId.Length > 0,
                "UniqueNameID should have meaningful length");
            Assert.IsTrue(uniqueId.Length < 100,
                "UniqueNameID should not be excessively long");
            Assert.IsFalse(uniqueId.Contains(" "),
                "UniqueNameID should not contain spaces");
        }
    }
}
