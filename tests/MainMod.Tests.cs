using NUnit.Framework;
using KitchenMuffinUp;

namespace KitchenMuffinUp.Tests
{
    /// <summary>
    /// Unit tests for the Main mod initialization class.
    /// Tests the mod's identification, versioning, and configuration constants.
    /// </summary>
    [TestFixture]
    public class MainModTests
    {
        /// <summary>
        /// Test Case 1: Normal Case - Verify that MOD_GUID is correctly defined
        /// This tests the mod's unique global identifier used by the mod system.
        /// </summary>
        [Test]
        public void ModGuid_IsCorrectlyDefined()
        {
            // Arrange & Act
            string modGuid = Main.MOD_GUID;

            // Assert
            Assert.AreEqual("MuffinUpTeam.PlateUp.MuffinUp", modGuid,
                "MOD_GUID should match the expected identifier");
            Assert.IsFalse(string.IsNullOrEmpty(modGuid),
                "MOD_GUID should not be null or empty");
            Assert.IsTrue(modGuid.Contains("PlateUp"),
                "MOD_GUID should reference the PlateUp game");
            Assert.IsTrue(modGuid.Contains("MuffinUp"),
                "MOD_GUID should reference the MuffinUp mod");
        }

        /// <summary>
        /// Test Case 2: Configuration Case - Verify that MOD_NAME is correctly defined
        /// Tests the human-readable name of the mod.
        /// </summary>
        [Test]
        public void ModName_IsCorrectlyDefined()
        {
            // Arrange & Act
            string modName = Main.MOD_NAME;

            // Assert
            Assert.AreEqual("MuffinUp", modName,
                "MOD_NAME should be 'MuffinUp'");
            Assert.IsFalse(string.IsNullOrEmpty(modName),
                "MOD_NAME should not be null or empty");
            Assert.IsTrue(modName.Length > 0 && modName.Length < 50,
                "MOD_NAME should have reasonable length");
        }

        /// <summary>
        /// Test Case 3: Version Case - Verify that MOD_VERSION is in correct format
        /// Tests that the mod version follows semantic versioning (major.minor.patch).
        /// </summary>
        [Test]
        public void ModVersion_IsValidSemantic()
        {
            // Arrange & Act
            string modVersion = Main.MOD_VERSION;

            // Assert
            Assert.AreEqual("0.1.0", modVersion,
                "MOD_VERSION should match the project version");
            Assert.IsFalse(string.IsNullOrEmpty(modVersion),
                "MOD_VERSION should not be null or empty");
            // Check semantic versioning format (X.Y.Z)
            string[] versionParts = modVersion.Split('.');
            Assert.AreEqual(3, versionParts.Length,
                "MOD_VERSION should follow semantic versioning (major.minor.patch)");
        }

        /// <summary>
        /// Test Case 4: Authorship Case - Verify that MOD_AUTHOR is correctly defined
        /// Tests that the mod's author information is present and correct.
        /// </summary>
        [Test]
        public void ModAuthor_IsCorrectlyDefined()
        {
            // Arrange & Act
            string modAuthor = Main.MOD_AUTHOR;

            // Assert
            Assert.AreEqual("MuffinUp! Team", modAuthor,
                "MOD_AUTHOR should be 'MuffinUp! Team'");
            Assert.IsFalse(string.IsNullOrEmpty(modAuthor),
                "MOD_AUTHOR should not be null or empty");
            Assert.IsTrue(modAuthor.Contains("Team") || modAuthor.Contains("team"),
                "MOD_AUTHOR should indicate it's a team effort");
        }

        /// <summary>
        /// Test Case 5: Compatibility Case - Verify that MOD_GAMEVERSION is correctly defined
        /// Tests that the mod specifies compatible game versions.
        /// </summary>
        [Test]
        public void ModGameVersion_IsCorrectlyDefined()
        {
            // Arrange & Act
            string gameVersion = Main.MOD_GAMEVERSION;

            // Assert
            Assert.AreEqual(">=1.1.1", gameVersion,
                "MOD_GAMEVERSION should specify 1.1.1 or higher");
            Assert.IsFalse(string.IsNullOrEmpty(gameVersion),
                "MOD_GAMEVERSION should not be null or empty");
            Assert.IsTrue(gameVersion.Contains("1.1.1"),
                "MOD_GAMEVERSION should reference version 1.1.1");
        }

        /// <summary>
        /// Test Case 6: Consistency Case - Verify all mod constants are consistent
        /// Tests that mod constants maintain consistency and logical relationships.
        /// </summary>
        [Test]
        public void AllModConstants_AreConsistent()
        {
            // Arrange & Act
            string guid = Main.MOD_GUID;
            string name = Main.MOD_NAME;
            string version = Main.MOD_VERSION;
            string author = Main.MOD_AUTHOR;
            string gameVersion = Main.MOD_GAMEVERSION;

            // Assert
            Assert.IsNotEmpty(guid, "MOD_GUID should not be empty");
            Assert.IsNotEmpty(name, "MOD_NAME should not be empty");
            Assert.IsNotEmpty(version, "MOD_VERSION should not be empty");
            Assert.IsNotEmpty(author, "MOD_AUTHOR should not be empty");
            Assert.IsNotEmpty(gameVersion, "MOD_GAMEVERSION should not be empty");
            
            Assert.IsTrue(guid.Contains(name),
                "MOD_GUID should contain the MOD_NAME for consistency");
        }

        /// <summary>
        /// Test Case 7: Format Validation Case - Verify mod constants follow proper formats
        /// Tests that each constant adheres to proper formatting rules.
        /// </summary>
        [Test]
        public void ModConstants_HaveProperFormat()
        {
            // Arrange & Act
            string guid = Main.MOD_GUID;
            string version = Main.MOD_VERSION;

            // Assert GUID format (should use reverse domain notation)
            Assert.IsTrue(guid.Contains("."),
                "MOD_GUID should use reverse domain notation with dots");
            Assert.IsFalse(guid.Contains(" "),
                "MOD_GUID should not contain spaces");

            // Assert Version format (semantic versioning)
            string[] versionParts = version.Split('.');
            foreach (string part in versionParts)
            {
                Assert.IsTrue(int.TryParse(part, out _),
                    $"Each version part '{part}' should be numeric for semantic versioning");
            }
        }

        /// <summary>
        /// Test Case 8: Edge Case - Verify that version is not using future dates
        /// Tests that the mod version is reasonable and not unrealistic.
        /// </summary>
        [Test]
        public void ModVersion_IsReasonable()
        {
            // Arrange & Act
            string modVersion = Main.MOD_VERSION;
            string[] versionParts = modVersion.Split('.');

            // Assert
            Assert.AreEqual(3, versionParts.Length,
                "Version should have exactly 3 parts (major.minor.patch)");
            
            // Parse version numbers
            int.TryParse(versionParts[0], out int major);
            int.TryParse(versionParts[1], out int minor);
            int.TryParse(versionParts[2], out int patch);
            
            Assert.IsTrue(major >= 0, "Major version should be non-negative");
            Assert.IsTrue(minor >= 0, "Minor version should be non-negative");
            Assert.IsTrue(patch >= 0, "Patch version should be non-negative");
            Assert.IsTrue(major < 100, "Major version should be reasonable");
        }
    }
}
