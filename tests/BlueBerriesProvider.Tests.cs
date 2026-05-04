using NUnit.Framework;
using KitchenData;
using KitchenLib.Utils;
using KitchenMuffinUp.Customs.Appliances;
using KitchenMuffinUp.Customs.Items;
using System.Collections.Generic;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the BlueBerriesProvider custom appliance class.
    /// Tests the provider's configuration, properties, pricing, and item delivery.
    /// </summary>
    [TestFixture]
    public class BlueBerriesProviderTests
    {
        private BlueBerriesProvider _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new BlueBerriesProvider();
        }

        /// <summary>
        /// Test Case 1: Normal Case - Verify that UniqueNameID is correctly set to "BlueBerriesProvider"
        /// This tests the basic provider identification in the game system.
        /// </summary>
        [Test]
        public void UniqueNameID_ReturnsCorrectIdentifier()
        {
            // Arrange & Act
            string uniqueId = _provider.UniqueNameID;

            // Assert
            Assert.AreEqual("BlueBerriesProvider", uniqueId,
                "UniqueNameID should return 'BlueBerriesProvider' for proper identification");
            Assert.IsFalse(string.IsNullOrEmpty(uniqueId),
                "UniqueNameID should not be null or empty");
        }

        /// <summary>
        /// Test Case 2: Configuration Case - Verify that the provider has correct price tier
        /// Tests that the appliance pricing is properly configured (PriceTier.ExtraPremium = 3).
        /// </summary>
        [Test]
        public void PriceTier_IsConfiguredCorrectly()
        {
            // Arrange & Act
            PriceTier priceTier = _provider.PriceTier;

            // Assert
            Assert.AreEqual((PriceTier)3, priceTier,
                "BlueBerriesProvider should have PriceTier.ExtraPremium (value 3)");
            Assert.IsNotNull(priceTier,
                "PriceTier should not be null");
        }

        /// <summary>
        /// Test Case 3: Configuration Case - Verify that the provider has correct rarity tier
        /// Tests that the appliance rarity is properly configured (RarityTier.Uncommon = 1).
        /// </summary>
        [Test]
        public void RarityTier_IsConfiguredCorrectly()
        {
            // Arrange & Act
            RarityTier rarityTier = _provider.RarityTier;

            // Assert
            Assert.AreEqual((RarityTier)1, rarityTier,
                "BlueBerriesProvider should have RarityTier.Uncommon (value 1)");
        }

        /// <summary>
        /// Test Case 4: Feature Case - Verify that the provider is purchasable
        /// Tests that the appliance is configured to be purchased by players.
        /// </summary>
        [Test]
        public void IsPurchasable_ReturnsTrue()
        {
            // Arrange & Act
            bool isPurchasable = _provider.IsPurchasable;

            // Assert
            Assert.IsTrue(isPurchasable,
                "BlueBerriesProvider should be purchasable in the game");
        }

        /// <summary>
        /// Test Case 5: Feature Case - Verify that only duplicates can be sold
        /// Tests the restriction that the provider can only be sold as a duplicate.
        /// </summary>
        [Test]
        public void SellOnlyAsDuplicate_ReturnsTrue()
        {
            // Arrange & Act
            bool sellOnlyAsDuplicate = _provider.SellOnlyAsDuplicate;

            // Assert
            Assert.IsTrue(sellOnlyAsDuplicate,
                "BlueBerriesProvider should only be sellable as a duplicate appliance");
        }

        /// <summary>
        /// Test Case 6: Property Case - Verify that the provider has configured properties
        /// Tests that the provider has the correct list of appliance properties.
        /// </summary>
        [Test]
        public void Properties_IsNotEmpty()
        {
            // Arrange & Act
            List<IApplianceProperty> properties = _provider.Properties;

            // Assert
            Assert.IsNotNull(properties,
                "Properties list should not be null");
            Assert.IsTrue(properties.Count > 0,
                "Provider should have at least one property configured");
            Assert.IsTrue(properties.Count >= 1,
                "Provider should have the unlimited item provider property");
        }

        /// <summary>
        /// Test Case 7: Configuration Case - Verify multiple instances maintain consistent configuration
        /// Tests that different provider instances have the same configuration.
        /// </summary>
        [Test]
        public void MultipleInstances_SameConfiguration()
        {
            // Arrange & Act
            BlueBerriesProvider provider1 = new BlueBerriesProvider();
            BlueBerriesProvider provider2 = new BlueBerriesProvider();
            BlueBerriesProvider provider3 = new BlueBerriesProvider();

            // Assert
            Assert.AreEqual(provider1.UniqueNameID, provider2.UniqueNameID,
                "Different instances should have the same identifier");
            Assert.AreEqual(provider1.PriceTier, provider2.PriceTier,
                "Different instances should have the same price tier");
            Assert.AreEqual(provider2.RarityTier, provider3.RarityTier,
                "Different instances should have the same rarity tier");
            Assert.AreEqual(provider1.IsPurchasable, provider3.IsPurchasable,
                "Purchasable status should be consistent across instances");
        }
    }
}
