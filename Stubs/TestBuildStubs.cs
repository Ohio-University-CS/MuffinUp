using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine
{
    public class Object { }
    public class GameObject : Object { }
    public class AssetBundle
    {
        public T LoadAsset<T>(string name) => default;
    }

    public static class Debug
    {
        public static void Log(string message) { }
        public static void LogWarning(string message) { }
        public static void LogError(string message) { }
    }
}

namespace Kitchen
{
    public abstract class BaseMod
    {
        protected BaseMod(string guid, string name, string author, string version, string gameVersion, Assembly assembly)
        {
        }

        protected abstract void OnPostActivate(KitchenMods.Mod mod);
        protected abstract void OnUpdate();

        protected void AddGameDataObject<T>() { }
    }
}

namespace KitchenMods
{
    public class Mod
    {
        public List<T> GetPacks<T>() where T : new() => new List<T>();
    }

    public class AssetBundleModPack
    {
        public List<UnityEngine.AssetBundle> AssetBundles { get; } = new List<UnityEngine.AssetBundle>();
    }
}

namespace KitchenData
{
    public class Item { }
    public class Process { }
    public class Appliance { }
    public class ItemGroupView { }
    public class ApplianceInfo { }
    public class UnlockInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FlavourText { get; set; }
    }

    public enum Locale
    {
        Unknown = 0,
        English = 1
    }

    public enum PriceTier
    {
        Tier0 = 0,
        Tier1 = 1,
        Tier2 = 2,
        Tier3 = 3
    }

    public enum RarityTier
    {
        Tier0 = 0,
        Tier1 = 1
    }

    public enum DishType
    {
        Starter = 0
    }

    public enum UnlockGroup
    {
        Group0 = 0,
        Group1 = 1
    }

    public enum CardType
    {
        Type0 = 0
    }
}

namespace KitchenLib.Customs
{
    public interface IApplianceProperty { }

    public class CustomItem
    {
        public virtual string UniqueNameID => string.Empty;
        public virtual UnityEngine.GameObject Prefab => null;
        public virtual KitchenData.Appliance DedicatedProvider => null;
    }

    public class CustomAppliance
    {
        public virtual string UniqueNameID => string.Empty;
        public virtual UnityEngine.GameObject Prefab => null;
        public virtual List<IApplianceProperty> Properties => new List<IApplianceProperty>();
        public virtual int PriceTier => 0;
        public virtual int RarityTier => 0;
        public virtual bool IsPurchasable => false;
        public virtual bool SellOnlyAsDuplicate => false;
        public virtual List<(KitchenData.Locale, KitchenData.ApplianceInfo)> InfoList => new List<(KitchenData.Locale, KitchenData.ApplianceInfo)>();
        public virtual void OnRegister(KitchenData.Appliance gameDataObject) { }
    }

    public class CustomDish
    {
        public virtual string UniqueNameID => string.Empty;
        public virtual bool IsUnlockable => false;
        public virtual KitchenData.UnlockGroup UnlockGroup => KitchenData.UnlockGroup.Group0;
        public virtual KitchenData.CardType CardType => KitchenData.CardType.Type0;
        public virtual object DishCustomerChange => null;
        public virtual bool IsMainThatDoesNotNeedPlates => false;
        public virtual HashSet<KitchenData.Item> BlockProviders => new HashSet<KitchenData.Item>();
        public virtual KitchenData.DishType Type => KitchenData.DishType.Starter;
        public virtual int Difficulty => 0;
        public virtual List<string> StartingNameSet => new List<string>();
        public virtual HashSet<KitchenData.Item> MinimumIngredients => new HashSet<KitchenData.Item>();
        public virtual HashSet<KitchenData.Process> RequiredProcesses => new HashSet<KitchenData.Process>();
        public virtual UnityEngine.GameObject DisplayPrefab => null;
        public virtual UnityEngine.GameObject IconPrefab => null;
        public virtual bool IsAvailableAsLobbyOption => false;
        public virtual Dictionary<KitchenData.Locale, string> Recipe => new Dictionary<KitchenData.Locale, string>();
        public virtual List<(KitchenData.Locale, KitchenData.UnlockInfo)> InfoList => new List<(KitchenData.Locale, KitchenData.UnlockInfo)>();
    }

    public class CustomItemGroup<T>
    {
        public virtual string UniqueNameID => string.Empty;
    }

    public class CustomGameDataObject<T>
    {
        public virtual void OnRegister(T gameDataObject) { }
        public T GameDataObject => default;
    }
}

namespace KitchenLib.Utils
{
    public static class GDOUtils
    {
        public static T GetCustomGameDataObject<T>() => default;
        public static T GetExistingGDO<T>(object obj) => default;
    }

    public static class MaterialUtils
    {
        public static UnityEngine.GameObject AssignMaterialsByNames(UnityEngine.GameObject obj) => obj;
    }

    public static class KitchenPropertiesUtils
    {
        public static IApplianceProperty GetUnlimitedCItemProvider(int id) => default;
    }
}

namespace KitchenLib.References
{
    public static class ItemReferences
    {
        public static int MixingBowlEmpty;
        public static int Plate;
        public static int Flour;
        public static int Sugar;
        public static int Egg;
        public static int Milk;
        public static int CupcakeTray;
    }

    public static class ProcessReferences
    {
        public static int RequireOven;
    }
}
