using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenMuffinUp.Customs.Items;

public class Muffin : CustomItem
{
    public override string UniqueNameID => "Muffin";

    public override GameObject Prefab
    {
        get
        {
            try
            {
                // Use CupcakeTray prefab for the baked muffin
                Item trayItem = (Item)GDOUtils.GetExistingGDO(ItemReferences.CupcakeTray);
                if (trayItem != null && trayItem.Prefab != null)
                {
                    return trayItem.Prefab;
                }
            }
            catch
            {
                Main.LogWarning("Failed to load Muffin prefab from CupcakeTray");
            }

            return null;
        }
    }
}
