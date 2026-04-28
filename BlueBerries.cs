// using KitchenData;
// using KitchenLib.References;
// using KitchenLib.Utils;
// using UnityEngine;

// namespace KitchenMuffinUp.Customs.Items;

// public class BlueBerries : CustomItem
// {
//     public override string UniqueNameID => "BlueBerries";

//     public override GameObject Prefab
//     {
//         get
//         {
//             try
//             {
//                 // Use existing Blueberries item from game
//                 Item blueberriesItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.Blueberries);
//                 if (blueberriesItem != null && blueberriesItem.Prefab != null)
//                 {
//                     return blueberriesItem.Prefab;
//                 }
//             }
//             catch
//             {
//                 Main.LogWarning("Failed to load Blueberries prefab from game");
//             }

//             return null;
//         }
//     }

//     public override Appliance DedicatedProvider => null;  // Use existing blueberries provider from game
// }