using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenMuffinUp
{
    public class MuffinTray : CustomItem
    {
        public override string UniqueNameID => "MuffinTray";

        public override GameObject Prefab => GetPrefab();

        public override ItemValue ItemValue => ItemValue.Small;

        public override ItemCategory ItemCategory => ItemCategory.Generic;

        public override Item DisposesTo => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);

        public override Item DuplicateItem => null;

        public override int DuplicateCount => 0;

        public override bool IsIndisposable => false;

        public override HashSet<Item.ItemProcess> Processes => new HashSet<Item.ItemProcess>();

        private GameObject GetPrefab()
        {
            try
            {
                if (Main.Bundle != null)
                {
                    return Main.Bundle.LoadAsset<GameObject>("Blueberrystack");
                }
            }
            catch
            {
                Main.LogWarning("Failed to load MuffinTray prefab from bundle");
            }

            return null;
        }
    }
}
