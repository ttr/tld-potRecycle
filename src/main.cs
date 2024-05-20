global using Il2Cpp;
using UnityEngine.SceneManagement;
using MelonLoader;
using UnityEngine;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Gear;

namespace potRecycle
{
    public static class BuildInfo
    {
        public const string Name = "potRecycle"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Ability to smelt Cans, Pots and skillets."; // Description for the Mod.  (Set as null if none)
        public const string Author = "ttr"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "0.2.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }
    internal class ttrRnStripped : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}