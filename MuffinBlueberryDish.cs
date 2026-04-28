// using System.Collections.Generic;
// using KitchenData;
// using KitchenLib.Customs;
// using KitchenLib.References;
// using KitchenLib.Utils;
// using UnityEngine;

// namespace KitchenMuffinUp.Customs.Dishes;

// public class MuffinBlueberryDish : CustomDish
// {
//     public override string UniqueNameID => "MuffinBlueberry";

//     public override bool IsUnlockable => true;

//     public override UnlockGroup UnlockGroup => (UnlockGroup)1;
//     public override CardType CardType => (CardType)0;

//     public override DishCustomerChange CustomerMultiplier => (DishCustomerChange)4;

//     public override bool IsMainThatDoesNotNeedPlates => false;

//     public override HashSet<Item> BlockProviders => new HashSet<Item>();

//     public override DishType Type => (DishType)0;

//     public override int Difficulty => 2;

//     public override List<string> StartingNameSet => new List<string>
//     {
//         "Blueberry Bliss",
//         "Berry Best",
//         "Blueberry Dream",
//         "Supreme Berries",
//         "The Berry Muffin"
//     };

//     public override HashSet<Item> MinimumIngredients => new HashSet<Item>
//     {
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.MixingBowlEmpty),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.CupcakeTray),
//         (Item)GDOUtils.GetExistingGDO(ItemReferences.Blueberries),
//     };

//     public override HashSet<Process> RequiredProcesses => new HashSet<Process>
//     {
//         (Process)GDOUtils.GetExistingGDO(ProcessReferences.RequireOven)
//     };

//     public override GameObject DisplayPrefab => GetDisplayPrefab();

//     public override GameObject IconPrefab => GetIconPrefab();

//     public override bool IsAvailableAsLobbyOption => true;

//     public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
//     {
//         {
//             (Locale)1,
//                 "Combine flour, sugar, eggs, and milk with fresh blueberries. Bake in cupcake tin until golden!"
//         }
//     };

//     public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
//     {
//         (
//             (Locale)1,
//                 new UnlockInfo
//             {
//                 Name = "Blueberry Muffin",
//                 Description = "Adds Blueberry Muffin as a Starter",
//                 FlavourText = "A delicious muffin bursting with fresh blueberries!"
//             }
//         )
//     };

//     private GameObject GetDisplayPrefab()
//     {
//         try
//         {
//             // Use existing Cupcake item from game
//             Item cupcakeItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.Cupcake);
//             if (cupcakeItem != null && cupcakeItem.Prefab != null)
//             {
//                 return cupcakeItem.Prefab;
//             }
//         }
//         catch
//         {
//             Main.LogWarning("Failed to load DisplayPrefab from Cupcake item");
//         }

//         return null;
//     }

//     private GameObject GetIconPrefab()
//     {
//         try
//         {
//             // Use existing Cupcake item from game
//             Item cupcakeItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.Cupcake);
//             if (cupcakeItem != null && cupcakeItem.Prefab != null)
//             {
//                 return cupcakeItem.Prefab;
//             }
//         }
//         catch
//         {
//             Main.LogWarning("Failed to load IconPrefab from Cupcake item");
//         }

//         return null;
//     }
// }