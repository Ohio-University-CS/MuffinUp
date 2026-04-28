using Kitchen;
using KitchenLib;
using KitchenMods;
using KitchenLib.Utils;
using KitchenData;
using KitchenMuffinUp.Customs.Dishes;
using KitchenMuffinUp.Customs.Items;
using System.Reflection;
using UnityEngine;

namespace KitchenMuffinUp
{
    internal class Main : BaseMod
    {
        public const string MOD_GUID = "MuffinUpTeam.PlateUp.MuffinUp";
        public const string MOD_NAME = "MuffinUp";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "MuffinUp! Team";
        public const string MOD_GAMEVERSION = ">=1.1.1";

        public Main() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            LogInfo("Registering MuffinUp content...");

            try
            {
                AddGameDataObject<Muffin>();
                LogInfo("Successfully registered Muffin item!");
            }
            catch (System.Exception ex)
            {
                LogError($"Failed to register Muffin item: {ex.Message}");
            }

            try
            {
                AddGameDataObject<MuffinDish>();
                LogInfo("Successfully registered Muffin dish!");
            }
            catch (System.Exception ex)
            {
                LogError($"Failed to register Muffin dish: {ex.Message}");
            }
        }

        protected override void OnUpdate()
        {
        }

        #region Logging
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] {_log}"); }
        public static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] {_log}"); }
        public static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] {_log}"); }
        #endregion
    }
}


