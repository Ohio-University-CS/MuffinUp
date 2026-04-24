using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenMuffinUp
{
    public class BlueberryMuffinTrayStack : CustomItemGroup
    {
        public override string UniqueNameID => "BlueberryMuffinTrayStack";

        public override List<Item> Items => new List<Item>
        {
            (Item)GDOUtils.GetExistingGDO(ItemReferences.Blueberries),
            GetMuffinTray()
        };

        public override Item Result => GetMuffinTray();

        public override int MaxStackSize => 1;

        public override bool PreventNormalGroups => false;

        public override bool CanContainNullItems => false;

        public override GameObject Prefab => GetPrefab();

        private Item GetMuffinTray()
        {
            return (Item)GDOUtils.GetExistingGDO(typeof(MuffinTray));
        }

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
                Main.LogWarning("Failed to load BlueberryMuffinTrayStack prefab from bundle");
            }

            return null;
        }
    }
}
