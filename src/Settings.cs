using System.Reflection;
using ModSettings;

namespace potRecycle
{
    internal class potRecycleSettings : JsonModSettings
    {
        [Section(" ")]

        [Name("Can smelting")]
        [Description("Add ability to smelt can/pots to scrap.")]
        public bool canSmeltingEnabled = true;

        [Name("Pot smelting")]
        [Description("Add ability to smelt can/pots to scrap.")]
        public bool potSmeltingEnabled = true;

        [Name("Skillet smelting")]
        [Description("Add ability to smelt can/pots to scrap.")]
        public bool skilletSmeltingEnabled = true;
    }
    internal static class Settings
    {
        public static potRecycleSettings options;
        public static void OnLoad()
        {
            options = new potRecycleSettings();
            options.AddToModSettings("Pot recycle Settings");
        }
    }
    
}