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
