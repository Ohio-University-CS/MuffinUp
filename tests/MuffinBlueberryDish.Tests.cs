using NUnit.Framework;
using KitchenData;
using KitchenLib.Customs;
using KitchenMuffinUp.Customs.Dishes;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the MuffinBlueberryDish custom dish class.
    /// Tests the blueberry muffin variant dish configuration and properties.
    /// </summary>
    [TestFixture]
    public class MuffinBlueberryDishTests
    {
        private MuffinBlueberryDish _muffinBlueberryDish;

        [SetUp]
        public void SetUp()
        {
            _muffinBlueberryDish = new MuffinBlueberryDish();
        }

        /// <summary>
        /// Test Case 1: Normal Case - Verify that UniqueNameID is correctly set to "MuffinBlueberryDish"
        /// This tests the basic dish variant identification in the game system.
        /// </summary>
        [Test]
        public void UniqueNameID_ReturnsCorrectIdentifier()
        {
            // Arrange & Act
            string uniqueId = _muffinBlueberryDish.UniqueNameID;

            // Assert
            Assert.AreEqual("MuffinBlueberryDish", uniqueId,
                "UniqueNameID should return 'MuffinBlueberryDish' for proper identification");
            Assert.IsFalse(string.IsNullOrEmpty(uniqueId),
                "UniqueNameID should not be null or empty");
        }

        /// <summary>
        /// Test Case 2: Consistency Case - Verify that UniqueNameID returns the same value on multiple calls
        /// Tests that the identifier remains consistent across multiple accesses.
        /// </summary>
        [Test]
        public void UniqueNameID_ConsistencyAcrossMultipleCalls()
        {
            // Arrange & Act
            string firstCall = _muffinBlueberryDish.UniqueNameID;
            string secondCall = _muffinBlueberryDish.UniqueNameID;
            string thirdCall = _muffinBlueberryDish.UniqueNameID;

            // Assert
            Assert.AreEqual(firstCall, secondCall,
                "UniqueNameID should return consistent value on first and second call");
            Assert.AreEqual(secondCall, thirdCall,
                "UniqueNameID should return consistent value on second and third call");
            Assert.AreEqual("MuffinBlueberryDish", firstCall,
                "All calls should return the expected identifier");
        }

        /// <summary>
        /// Test Case 3: Inheritance Case - Verify that MuffinBlueberryDish extends CustomDish correctly
        /// Tests that the class properly inherits from the CustomDish base class.
        /// </summary>
        [Test]
        public void MuffinBlueberryDish_IsValidCustomDish()
        {
            // Arrange & Act
            MuffinBlueberryDish dish = new MuffinBlueberryDish();

            // Assert - Verify inheritance and type
            Assert.IsInstanceOf<CustomDish>(dish,
                "MuffinBlueberryDish should inherit from CustomDish");
            Assert.IsNotNull(dish.UniqueNameID,
                "CustomDish derived class should have a UniqueNameID");
            Assert.IsTrue(dish.UniqueNameID.Length > 0,
                "UniqueNameID should have meaningful content");
        }

        /// <summary>
        /// Test Case 4: Identity Case - Verify that multiple instances have the same identifier
        /// Tests that different instances maintain consistent dish variant identification.
        /// </summary>
        [Test]
        public void MultipleInstances_SameIdentifier()
        {
            // Arrange & Act
            MuffinBlueberryDish dish1 = new MuffinBlueberryDish();
            MuffinBlueberryDish dish2 = new MuffinBlueberryDish();
            MuffinBlueberryDish dish3 = new MuffinBlueberryDish();

            // Assert
            Assert.AreEqual(dish1.UniqueNameID, dish2.UniqueNameID,
                "Different instances should have the same UniqueNameID");
            Assert.AreEqual(dish2.UniqueNameID, dish3.UniqueNameID,
                "All instances should maintain consistent identifiers");
            Assert.AreEqual("MuffinBlueberryDish", dish1.UniqueNameID,
                "Instance ID should match expected constant");
        }

        /// <summary>
        /// Test Case 5: Naming Convention Case - Verify that the identifier follows naming conventions
        /// Tests that the identifier is properly formatted and meaningful.
        /// </summary>
        [Test]
        public void UniqueNameID_FollowsNamingConvention()
        {
            // Arrange & Act
            string uniqueId = _muffinBlueberryDish.UniqueNameID;

            // Assert
            Assert.IsTrue(uniqueId.Contains("Muffin"),
                "UniqueNameID should contain 'Muffin' to relate to the base dish");
            Assert.IsTrue(uniqueId.Contains("Blueberry"),
                "UniqueNameID should contain 'Blueberry' to indicate the variant");
            Assert.IsTrue(uniqueId.Length > 10,
                "UniqueNameID should be descriptive with meaningful length");
            Assert.IsFalse(uniqueId.Contains(" "),
                "UniqueNameID should not contain spaces");
        }

        /// <summary>
        /// Test Case 6: Variant Distinction Case - Verify that this dish is distinct from the base Muffin
        /// Tests that the variant dish has a unique identifier different from the base muffin.
        /// </summary>
        [Test]
        public void MuffinBlueberryDish_IsDistinctFromBaseMuffin()
        {
            // Arrange & Act
            string blueberryDishId = _muffinBlueberryDish.UniqueNameID;
            var baseMuffinDish = new MuffinDish();
            string baseName =" Muffin";

            // Assert
            Assert.AreNotEqual(blueberryDishId, baseName,
                "Blueberry variant should have a different ID from the base muffin");
            Assert.IsTrue(blueberryDishId.Contains("Blueberry"),
                "Blueberry variant should be identifiable by its name");
            Assert.IsTrue(blueberryDishId.Length > baseName.Length,
                "Variant ID should be more specific than the base");
        }

        /// <summary>
        /// Test Case 7: Type Consistency Case - Verify that the class maintains dish type consistency
        /// Tests that all instances of this variant are properly typed as CustomDish.
        /// </summary>
        [Test]
        public void AllInstances_MaintainDishTypeConsistency()
        {
            // Arrange & Act
            MuffinBlueberryDish dish1 = new MuffinBlueberryDish();
            MuffinBlueberryDish dish2 = new MuffinBlueberryDish();
            MuffinBlueberryDish dish3 = new MuffinBlueberryDish();

            // Assert all maintain proper type
            Assert.IsInstanceOf<CustomDish>(dish1);
            Assert.IsInstanceOf<CustomDish>(dish2);
            Assert.IsInstanceOf<CustomDish>(dish3);
            
            Assert.AreEqual(dish1.UniqueNameID, dish2.UniqueNameID);
            Assert.AreEqual(dish2.UniqueNameID, dish3.UniqueNameID);
        }
    }
}
