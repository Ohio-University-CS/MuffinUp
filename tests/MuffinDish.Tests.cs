using NUnit.Framework;
using KitchenData;
using KitchenLib.Utils;
using KitchenMuffinUp.Customs.Dishes;
using System.Collections.Generic;
using System.Linq;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the MuffinDish custom dish class.
    /// Tests the dish configuration, ingredients, difficulty, and game properties.
    /// </summary>
    [TestFixture]
    public class MuffinDishTests
    {
        private MuffinDish _muffinDish;

        [SetUp]
        public void SetUp()
        {
            _muffinDish = new MuffinDish();
        }

        /// <summary>
        /// Test Case 1: Normal Case - Verify that UniqueNameID is correctly set to "Muffin"
        /// This tests the basic dish identification in the game system.
        /// </summary>
        [Test]
        public void UniqueNameID_ReturnsCorrectIdentifier()
        {
            // Arrange & Act
            string uniqueId = _muffinDish.UniqueNameID;

            // Assert
            Assert.AreEqual("Muffin", uniqueId,
                "UniqueNameID should return 'Muffin' for proper dish identification");
            Assert.IsFalse(string.IsNullOrEmpty(uniqueId),
                "UniqueNameID should not be null or empty");
        }

        /// <summary>
        /// Test Case 2: Configuration Case - Verify that the dish is unlockable
        /// Tests that players must unlock this dish to prepare it.
        /// </summary>
        [Test]
        public void IsUnlockable_ReturnsTrue()
        {
            // Arrange & Act
            bool isUnlockable = _muffinDish.IsUnlockable;

            // Assert
            Assert.IsTrue(isUnlockable,
                "Muffin dish should be unlockable by players");
        }

        /// <summary>
        /// Test Case 3: Difficulty Case - Verify that the dish has starter level difficulty
        /// Tests that the muffin is configured as a beginning dish (difficulty 1).
        /// </summary>
        [Test]
        public void Difficulty_IsStarterLevel()
        {
            // Arrange & Act
            int difficulty = _muffinDish.Difficulty;

            // Assert
            Assert.AreEqual(1, difficulty,
                "Muffin dish should have difficulty 1 (starter level)");
            Assert.IsTrue(difficulty > 0,
                "Difficulty should be a positive value");
            Assert.IsTrue(difficulty <= 5,
                "Difficulty should be within the game's difficulty range");
        }

        /// <summary>
        /// Test Case 4: Type Case - Verify that the dish is configured as a starter type
        /// Tests that the muffin is a starter dish, not a main course (DishType = 0).
        /// </summary>
        [Test]
        public void Type_IsStarterDish()
        {
            // Arrange & Act
            DishType dishType = _muffinDish.Type;

            // Assert
            Assert.AreEqual((DishType)0, dishType,
                "Muffin should be a starter type dish (DishType 0)");
        }

        /// <summary>
        /// Test Case 5: Property Case - Verify that the dish does not need plates
        /// Tests the configuration that mains need plates but this doesn't.
        /// </summary>
        [Test]
        public void IsMainThatDoesNotNeedPlates_ReturnsFalse()
        {
            // Arrange & Act
            bool isMainWithoutPlates = _muffinDish.IsMainThatDoesNotNeedPlates;

            // Assert
            Assert.IsFalse(isMainWithoutPlates,
                "Since this is a starter, it should need plates for serving");
        }

        /// <summary>
        /// Test Case 6: Customer Case - Verify that the dish has correct customer multiplier
        /// Tests that the muffin attracts the proper amount of customers (multiplier 3).
        /// </summary>
        [Test]
        public void CustomerMultiplier_IsConfiguredCorrectly()
        {
            // Arrange & Act
            DishCustomerChange multiplier = _muffinDish.CustomerMultiplier;

            // Assert
            Assert.AreEqual((DishCustomerChange)3, multiplier,
                "Muffin dish should have customer multiplier of 3");
        }

        /// <summary>
        /// Test Case 7: Unlock Case - Verify that the dish belongs to correct unlock group
        /// Tests that the muffin is grouped with other starters for unlock purposes.
        /// </summary>
        [Test]
        public void UnlockGroup_IsStarterGroup()
        {
            // Arrange & Act
            UnlockGroup unlockGroup = _muffinDish.UnlockGroup;

            // Assert
            // UnlockGroup 1 is the starter group
            Assert.AreEqual((UnlockGroup)1, unlockGroup,
                "Muffin should be in unlock group 1 (starter dishes)");
        }

        /// <summary>
        /// Test Case 8: Card Case - Verify that the dish has correct card type
        /// Tests that the muffin uses standard card type (CardType 0).
        /// </summary>
        [Test]
        public void CardType_IsStandardType()
        {
            // Arrange & Act
            CardType cardType = _muffinDish.CardType;

            // Assert
            Assert.AreEqual((CardType)0, cardType,
                "Muffin should use standard card type (CardType 0)");
        }

        /// <summary>
        /// Test Case 9: Ingredients Case - Verify that the dish is configured with minimum ingredients
        /// Tests that the muffin has the required base ingredients set.
        /// </summary>
        [Test]
        public void MinimumIngredients_IsConfigured()
        {
            // Arrange & Act
            HashSet<Item> minimumIngredients = _muffinDish.MinimumIngredients;

            // Assert
            Assert.IsNotNull(minimumIngredients,
                "MinimumIngredients should not be null");
            Assert.IsTrue(minimumIngredients.Count > 0,
                "Muffin should have at least one minimum ingredient");
            Assert.IsTrue(minimumIngredients.Count >= 5,
                "Muffin recipe should require multiple ingredients");
        }

        /// <summary>
        /// Test Case 10: Names Case - Verify that the dish has multiple starting names
        /// Tests that variations are configured for dish naming (at least 3 names).
        /// </summary>
        [Test]
        public void StartingNameSet_HasMultipleNames()
        {
            // Arrange & Act
            List<string> startingNames = _muffinDish.StartingNameSet;

            // Assert
            Assert.IsNotNull(startingNames,
                "StartingNameSet should not be null");
            Assert.IsTrue(startingNames.Count >= 5,
                "Muffin should have at least 5 starting name options");
            Assert.IsTrue(startingNames.All(name => !string.IsNullOrEmpty(name)),
                "All starting names should be non-empty strings");
            Assert.IsTrue(startingNames.Any(name => name.Contains("Muffin")),
                "At least one name should contain 'Muffin'");
        }

        /// <summary>
        /// Test Case 11: Consistency Case - Verify that multiple instances maintain consistent configuration
        /// Tests that different dish instances are identically configured.
        /// </summary>
        [Test]
        public void MultipleInstances_SameConfiguration()
        {
            // Arrange & Act
            MuffinDish dish1 = new MuffinDish();
            MuffinDish dish2 = new MuffinDish();

            // Assert
            Assert.AreEqual(dish1.UniqueNameID, dish2.UniqueNameID,
                "Different instances should have the same identifier");
            Assert.AreEqual(dish1.Difficulty, dish2.Difficulty,
                "Different instances should have the same difficulty");
            Assert.AreEqual(dish1.Type, dish2.Type,
                "Different instances should have the same type");
        }
    }
}
