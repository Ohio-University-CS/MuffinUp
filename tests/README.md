# MuffinUp Unit Tests

This folder contains comprehensive unit tests for the MuffinUp PlateUp mod. The tests use the **NUnit** framework and cover all major components and classes.

## Test Coverage

### 1. **BlueBerries.Tests.cs** - Custom Item Tests (5 Test Cases)
Tests the `BlueBerries` custom item class.

**Test Cases:**
- **UniqueNameID_ReturnsCorrectIdentifier** (Normal Case): Verifies the item has the correct unique identifier "BlueBerries"
- **UniqueNameID_ConsistencyAcrossMultipleCalls** (Edge Case): Ensures the identifier is consistent across multiple property accesses
- **DedicatedProvider_ReturnsValidAppliance** (Error Case): Validates that the provider appliance is properly configured
- **MultipleInstances_SameIdentifier** (Boundary Case): Confirms that different instances have the same identifier
- **BlueBerries_IsValidCustomItem** (Integration Case): Verifies proper inheritance from CustomItem

---

### 2. **BlueBerriesProvider.Tests.cs** - Appliance Provider Tests (7 Test Cases)
Tests the `BlueBerriesProvider` custom appliance class.

**Test Cases:**
- **UniqueNameID_ReturnsCorrectIdentifier** (Normal Case): Verifies correct provider identification
- **PriceTier_IsConfiguredCorrectly** (Configuration Case): Validates price tier is set to ExtraPremium (3)
- **RarityTier_IsConfiguredCorrectly** (Configuration Case): Validates rarity tier is set to Uncommon (1)
- **IsPurchasable_ReturnsTrue** (Feature Case): Confirms the appliance can be purchased
- **SellOnlyAsDuplicate_ReturnsTrue** (Feature Case): Validates the sell restriction
- **Properties_IsNotEmpty** (Property Case): Ensures properties are configured
- **MultipleInstances_SameConfiguration** (Consistency Case): Verifies consistent configuration across instances

---

### 3. **MuffinDish.Tests.cs** - Dish Configuration Tests (11 Test Cases)
Tests the `MuffinDish` custom dish class.

**Test Cases:**
- **UniqueNameID_ReturnsCorrectIdentifier** (Normal Case): Verifies dish identification
- **IsUnlockable_ReturnsTrue** (Configuration Case): Confirms the dish is unlockable
- **Difficulty_IsStarterLevel** (Difficulty Case): Validates difficulty is 1 (starter level)
- **Type_IsStarterDish** (Type Case): Confirms dish type is Starter (0)
- **IsMainThatDoesNotNeedPlates_ReturnsFalse** (Property Case): Validates plate requirement
- **CustomerMultiplier_IsConfiguredCorrectly** (Customer Case): Verifies customer multiplier is 3
- **UnlockGroup_IsStarterGroup** (Unlock Case): Confirms unlock group is 1 (starters)
- **CardType_IsStandardType** (Card Case): Validates card type is standard (0)
- **MinimumIngredients_IsConfigured** (Ingredients Case): Ensures ingredients are set
- **StartingNameSet_HasMultipleNames** (Names Case): Verifies at least 5 starting names
- **MultipleInstances_SameConfiguration** (Consistency Case): Confirms configuration consistency

---

### 4. **MuffinPlate.Tests.cs** - Item Group Tests (5 Test Cases)
Tests the `MuffinPlate` custom item group class.

**Test Cases:**
- **UniqueNameID_ReturnsCorrectIdentifier** (Normal Case): Verifies item group identification
- **UniqueNameID_ConsistencyAcrossMultipleCalls** (Consistency Case): Ensures identifier consistency
- **MuffinPlate_IsValidCustomItemGroup** (Inheritance Case): Validates proper class inheritance
- **MultipleInstances_SameIdentifier** (Identity Case): Confirms instance identifier consistency
- **UniqueNameID_FollowsNamingConvention** (Naming Convention Case): Validates naming standards

---

### 5. **MuffinBlueberryDish.Tests.cs** - Variant Dish Tests (7 Test Cases)
Tests the `MuffinBlueberryDish` custom dish variant class.

**Test Cases:**
- **UniqueNameID_ReturnsCorrectIdentifier** (Normal Case): Verifies variant identification
- **UniqueNameID_ConsistencyAcrossMultipleCalls** (Consistency Case): Ensures identifier consistency
- **MuffinBlueberryDish_IsValidCustomDish** (Inheritance Case): Validates class inheritance
- **MultipleInstances_SameIdentifier** (Identity Case): Confirms instance consistency
- **UniqueNameID_FollowsNamingConvention** (Naming Convention Case): Validates naming standards
- **MuffinBlueberryDish_IsDistinctFromBaseMuffin** (Variant Distinction Case): Ensures distinct variant identification
- **AllInstances_MaintainDishTypeConsistency** (Type Consistency Case): Validates type consistency

---

### 6. **MainMod.Tests.cs** - Mod Configuration Tests (8 Test Cases)
Tests the `Main` mod initialization class and constants.

**Test Cases:**
- **ModGuid_IsCorrectlyDefined** (Normal Case): Verifies mod GUID is correct
- **ModName_IsCorrectlyDefined** (Configuration Case): Validates mod name is "MuffinUp"
- **ModVersion_IsValidSemantic** (Version Case): Confirms semantic versioning format
- **ModAuthor_IsCorrectlyDefined** (Authorship Case): Validates author name
- **ModGameVersion_IsCorrectlyDefined** (Compatibility Case): Confirms game version compatibility
- **AllModConstants_AreConsistent** (Consistency Case): Ensures all constants are consistent
- **ModConstants_HaveProperFormat** (Format Validation Case): Validates proper formatting
- **ModVersion_IsReasonable** (Edge Case): Confirms version reasonableness

---

## Running the Tests

### Prerequisites
- .NET Framework 4.7.2 or higher
- NUnit 3.13.3
- NUnit3TestAdapter 4.2.1
- Visual Studio, Rider, or another C# IDE

### Run Tests via Command Line
```bash
# Navigate to the tests directory
cd tests

# Run all tests
dotnet test

# Run specific test file
dotnet test --filter="MuffinDish"

# Run with verbose output
dotnet test --verbosity=detailed
```

### Run Tests in IDE
- **Visual Studio**: Open Test Explorer (Test > Test Explorer) and click "Run All"
- **Rider**: Open Test Explorer and run all or specific tests

## Test Statistics

- **Total Test Classes**: 6
- **Total Test Cases**: 43
- **Framework**: NUnit 3.13.3
- **Target Framework**: .NET 4.7.2

## Test Standards

Each test follows the **Arrange-Act-Assert (AAA)** pattern:
1. **Arrange**: Set up test data and conditions
2. **Act**: Execute the code being tested
3. **Assert**: Verify the results match expectations

### Test Case Types Covered:
- ✅ Normal Cases: Standard functionality testing
- ✅ Edge Cases: Boundary and extreme value testing
- ✅ Error Cases: Error handling and validation
- ✅ Consistency Cases: Multi-instance and repeated call testing
- ✅ Configuration Cases: Component configuration validation
- ✅ Integration Cases: Class inheritance and collaboration testing

## Notes

- All tests are independent and can run in any order
- Tests use clear naming conventions for easy identification
- Each test includes XML documentation describing its purpose
- Tests mock dependencies where appropriate to isolate components

## Future Enhancements

- Add integration tests for full mod workflow
- Add performance benchmarks
- Add tests for visual/graphics components
- Add multiplayer scenario testing
