// using System.Collections.Generic;
// using Kitchen;
// using KitchenData;
// using KitchenLib.Customs;
// using KitchenLib.References;
// using KitchenLib.Utils;
// using UnityEngine;

// namespace KitchenMuffinUp.Customs.ItemGroups;

// public class MuffinPlate : CustomItemGroup<ItemGroupView>
// {
//     public override string UniqueNameID => "MuffinPlater";

//     public override List<ItemSet> RequiredItems => new List<ItemSet>
//     {
//         new ItemSet
//         {
//             Item = (Item)GDOUtils.GetExistingGDO(ItemReferences.Cupcake),
//             Phase = (ItemGroupPhase)0
//         }
//     };

//     public override GameObject Prefab => GetPrefab();

//     private GameObject GetPrefab()
//     {
//         try
//         {
//             // Use existing Cupcake item prefab from game
//             Item cupcakeItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.Cupcake);
//             if (cupcakeItem != null && cupcakeItem.Prefab != null)
//             {
//                 return cupcakeItem.Prefab;
//             }
//         }
//         catch
//         {
//             Main.LogWarning("Failed to load Cupcake prefab for MuffinPlate");
//         }

//         return null;
//     }
// }
