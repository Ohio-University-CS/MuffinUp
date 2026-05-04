// Made by Karli Nadsady with help from Copilot (because I have never made tests before)

using NUnit.Framework;
using KitchenMuffinUp;
using KitchenMuffinUp.Customs.Items;
using KitchenMuffinUp.Customs.Appliances;
using KitchenMuffinUp.Customs.Dishes;
using KitchenMuffinUp.Customs.ItemGroups;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Basic sanity tests - simple tests that verify fundamental properties.
    /// These tests are designed to always pass and verify core functionality exists.
    /// </summary>
    [TestFixture]
    public class BasicSanityTests
    {
        /// <summary>
        /// Test 1: Verify that BlueBerries class can be instantiated without errors
        /// </summary>
        [Test]
        public void Test_BlueBerries_CanBeInstantiated()
        {
            // Act - simply create an instance
            var blueBerries = new BlueBerries();
            
            // Assert - verify it's not null
            Assert.IsNotNull(blueBerries, "BlueBerries should be creatable");
        }

        /// <summary>
        /// Test 2: Verify that BlueBerriesProvider class can be instantiated without errors
        /// </summary>
        [Test]
        public void Test_BlueBerriesProvider_CanBeInstantiated()
        {
            // Act - simply create an instance
            var provider = new BlueBerriesProvider();
            
            // Assert - verify it's not null
            Assert.IsNotNull(provider, "BlueBerriesProvider should be creatable");
        }

        /// <summary>
        /// Test 3: Verify that MuffinDish class can be instantiated without errors
        /// </summary>
        [Test]
        public void Test_MuffinDish_CanBeInstantiated()
        {
            // Act - simply create an instance
            var dish = new MuffinDish();
            
            // Assert - verify it's not null
            Assert.IsNotNull(dish, "MuffinDish should be creatable");
        }

        /// <summary>
        /// Test 4: Verify that MuffinPlate class can be instantiated without errors
        /// </summary>
        [Test]
        public void Test_MuffinPlate_CanBeInstantiated()
        {
            // Act - simply create an instance
            var plate = new MuffinPlate();
            
            // Assert - verify it's not null
            Assert.IsNotNull(plate, "MuffinPlate should be creatable");
        }

        /// <summary>
        /// Test 5: Verify that MuffinBlueberryDish class can be instantiated without errors
        /// </summary>
        [Test]
        public void Test_MuffinBlueberryDish_CanBeInstantiated()
        {
            // Act - simply create an instance
            var blueberryDish = new MuffinBlueberryDish();
            
            // Assert - verify it's not null
            Assert.IsNotNull(blueberryDish, "MuffinBlueberryDish should be creatable");
        }
    }
}
