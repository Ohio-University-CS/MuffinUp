using NUnit.Framework;
using KitchenData;
using KitchenLib.Utils;
using KitchenMuffinUp.Customs.Items;
using KitchenMuffinUp.Customs.Appliances;
using UnityEngine;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the BlueBerries custom item class.
    /// Tests the item identification, prefab loading, and provider assignment.
    /// </summary>
    [TestFixture]
    public class BlueBerriestTests
    {
        private BlueBerries _blueBerries;

        [SetUp]
        public void SetUp()
        {
            _blueBerries = new BlueBerries();
        }

        /// <summary>
        /// Test Case 1: Normal Case - Verify that the UniqueNameID is correctly set to "BlueBerries"
        /// This tests the basic identifier property of the custom item.
        /// </summary>
        [Test]
        public void UniqueNameID_ReturnsCorrectIdentifier()
        {
            // Arrange & Act
            string uniqueId = _blueBerries.UniqueNameID;

            // Assert
            Assert.AreEqual("BlueBerries", uniqueId, 
                "UniqueNameID should return 'BlueBerries' for identification in the game system");
            Assert.IsFalse(string.IsNullOrEmpty(uniqueId),
                "UniqueNameID should not be null or empty");
        }

        /// <summary>
        /// Test Case 2: Edge Case - Verify that UniqueNameID returns the same value on multiple calls
        /// Ensures consistency of the property across multiple calls.
        /// </summary>
        [Test]
        public void UniqueNameID_ConsistencyAcrossMultipleCalls()
        {
            // Arrange & Act
            string firstCall = _blueBerries.UniqueNameID;
            string secondCall = _blueBerries.UniqueNameID;
            string thirdCall = _blueBerries.UniqueNameID;

            // Assert
            Assert.AreEqual(firstCall, secondCall,
                "UniqueNameID should return consistent value on first and second call");
            Assert.AreEqual(secondCall, thirdCall,
                "UniqueNameID should return consistent value on second and third call");
            Assert.AreEqual("BlueBerries", firstCall,
                "All calls should return the expected identifier");
        }

        /// <summary>
        /// Test Case 3: Error Case - Verify that the DedicatedProvider property returns a valid Appliance
        /// Tests the integration between the item and its provider appliance.
        /// </summary>
        [Test]
        public void DedicatedProvider_ReturnsValidAppliance()
        {
            // Arrange & Act
            Appliance dedicatedProvider = _blueBerries.DedicatedProvider;

            // Assert
            Assert.IsNotNull(dedicatedProvider,
                "DedicatedProvider should not be null - must have a valid provider appliance");
            Assert.IsInstanceOf<Appliance>(dedicatedProvider,
                "DedicatedProvider should return an Appliance type");
        }

        /// <summary>
        /// Test Case 4: Boundary Case - Verify that multiple BlueBerries instances have the same UniqueNameID
        /// Ensures that different instances maintain consistency.
        /// </summary>
        [Test]
        public void MultipleInstances_SameIdentifier()
        {
            // Arrange & Act
            BlueBerries berries1 = new BlueBerries();
            BlueBerries berries2 = new BlueBerries();
            BlueBerries berries3 = new BlueBerries();

            // Assert
            Assert.AreEqual(berries1.UniqueNameID, berries2.UniqueNameID,
                "Different instances should have the same UniqueNameID");
            Assert.AreEqual(berries2.UniqueNameID, berries3.UniqueNameID,
                "All instances should maintain consistent identifiers");
            Assert.AreEqual("BlueBerries", berries1.UniqueNameID,
                "Instance ID should match expected constant");
        }

        /// <summary>
        /// Test Case 5: Integration Case - Verify that the item is properly configured as a CustomItem
        /// Tests that BlueBerries is correctly derived from CustomItem class.
        /// </summary>
        [Test]
        public void BlueBerries_IsValidCustomItem()
        {
            // Arrange & Act
            BlueBerries berries = new BlueBerries();
            
            // Assert - Verify inheritance
            Assert.IsInstanceOf<CustomItem>(berries,
                "BlueBerries should inherit from CustomItem");
            Assert.IsNotNull(berries.UniqueNameID,
                "CustomItem derived class should have a UniqueNameID");
            Assert.IsTrue(berries.UniqueNameID.Length > 0,
                "UniqueNameID should have meaningful length");
        }
    }
}
