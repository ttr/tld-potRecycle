using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Gear;
using MelonLoader;

namespace potRecycle
{
    internal class potRecycle 
    {
        [HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Initialize))]
        public class Panel_Crafting_Initialize
        {
            private static void Postfix()
            {
                if (Settings.options.canSmeltingEnabled)
                {
                    InterfaceManager.GetInstance().m_BlueprintManager.m_AllBlueprints.Add(new BlueprintData()
                    {

                        name = "BLUEPRINT_GEAR_cans_to_scrap",

                        // Inputs
                        m_RequiredTool = null,
                        m_OptionalTools = new Il2CppReferenceArray<ToolsItem>(0),

                        // Outputs
                        m_CraftedResult = GetGearItemPrefab("GEAR_ScrapMetal"),
                        m_CraftedResultCount = 1,

                        // Process
                        m_Locked = false,
                        m_IgnoreLockInSurvival = false,
                        m_AppearsInStoryOnly = false,
                        m_AppearsInSurvivalOnly = false,
                        m_RequiresLight = false,
                        m_RequiresLitFire = false,
                        m_RequiredCraftingLocation = CraftingLocation.Forge,
                        m_DurationMinutes = 10,
                        m_CraftingAudio = MakeAudioEvent("PLAY_CRAFTINGARROWS"),

                        m_AppliedSkill = SkillType.None,
                        m_ImprovedSkill = SkillType.None,
                        m_CanIncreaseRepairSkill = false,
                        m_RequiredLiquid = new Il2CppReferenceArray<BlueprintData.RequiredLiquid>(0) { },
                        m_RequiredPowder = new Il2CppReferenceArray<BlueprintData.RequiredPowder>(0) { },

                        m_RequiredGear = new Il2CppReferenceArray<BlueprintData.RequiredGearItem>(1)
                        {
                            [0] = new BlueprintData.RequiredGearItem() { m_Count = 2, m_Item = GetGearItemPrefab("GEAR_RecycledCan") }
                        }
                    });
                }
                if (Settings.options.potSmeltingEnabled)
                {
                    InterfaceManager.GetInstance().m_BlueprintManager.m_AllBlueprints.Add(new BlueprintData()
                    {

                        name = "BLUEPRINT_GEAR_Pot_to_scrap",

                        // Inputs
                        m_RequiredTool = null,
                        m_OptionalTools = new Il2CppReferenceArray<ToolsItem>(0),

                        // Outputs
                        m_CraftedResult = GetGearItemPrefab("GEAR_ScrapMetal"),
                        m_CraftedResultCount = 4,

                        // Process
                        m_Locked = false,
                        m_IgnoreLockInSurvival = false,
                        m_AppearsInStoryOnly = false,
                        m_AppearsInSurvivalOnly = false,
                        m_RequiresLight = false,
                        m_RequiresLitFire = false,
                        m_RequiredCraftingLocation = CraftingLocation.Forge,
                        m_DurationMinutes = 15,
                        m_CraftingAudio = MakeAudioEvent("PLAY_CRAFTINGARROWS"),

                        m_AppliedSkill = SkillType.None,
                        m_ImprovedSkill = SkillType.None,
                        m_CanIncreaseRepairSkill = false,
                        m_RequiredLiquid = new Il2CppReferenceArray<BlueprintData.RequiredLiquid>(0) { },
                        m_RequiredPowder = new Il2CppReferenceArray<BlueprintData.RequiredPowder>(0) { },

                        m_RequiredGear = new Il2CppReferenceArray<BlueprintData.RequiredGearItem>(1)
                        {
                            [0] = new BlueprintData.RequiredGearItem() { m_Count = 1, m_Item = GetGearItemPrefab("GEAR_Cookingpot") }
                        }
                    });
                }
                if (Settings.options.skilletSmeltingEnabled)
                {
                    InterfaceManager.GetInstance().m_BlueprintManager.m_AllBlueprints.Add(new BlueprintData()
                    {

                        name = "BLUEPRINT_GEAR_Skillet_to_scrap",

                        // Inputs
                        m_RequiredTool = null,
                        m_OptionalTools = new Il2CppReferenceArray<ToolsItem>(0),

                        // Outputs
                        m_CraftedResult = GetGearItemPrefab("GEAR_ScrapMetal"),
                        m_CraftedResultCount = 4,

                        // Process
                        m_Locked = false,
                        m_IgnoreLockInSurvival = false,
                        m_AppearsInStoryOnly = false,
                        m_AppearsInSurvivalOnly = false,
                        m_RequiresLight = false,
                        m_RequiresLitFire = false,
                        m_RequiredCraftingLocation = CraftingLocation.Forge,
                        m_DurationMinutes = 15,
                        m_CraftingAudio = MakeAudioEvent("PLAY_CRAFTINGARROWS"),

                        m_AppliedSkill = SkillType.None,
                        m_ImprovedSkill = SkillType.None,
                        m_CanIncreaseRepairSkill = false,
                        m_RequiredLiquid = new Il2CppReferenceArray<BlueprintData.RequiredLiquid>(0) { },
                        m_RequiredPowder = new Il2CppReferenceArray<BlueprintData.RequiredPowder>(0) { },

                        m_RequiredGear = new Il2CppReferenceArray<BlueprintData.RequiredGearItem>(1)
                        {
                            [0] = new BlueprintData.RequiredGearItem() { m_Count = 1, m_Item = GetGearItemPrefab("GEAR_Skillet") }
                        }
                    });
                }

            }
            private static GearItem GetGearItemPrefab(string name)
            {
                return GearItem.LoadGearItemPrefab(name);
            }

            private static ToolsItem GetToolItemPrefab(string name)
            {
                return GearItem.LoadGearItemPrefab(name).m_ToolsItem;
            }
            public static Il2CppAK.Wwise.Event? MakeAudioEvent(string eventName)
            {
                if (eventName == null)
                {
                    return null;
                }
                uint eventId = AkSoundEngine.GetIDFromString(eventName);
                if (eventId <= 0 || eventId >= 4294967295)
                {
                    return null;
                }

                Il2CppAK.Wwise.Event newEvent = new();
                newEvent.WwiseObjectReference = new WwiseEventReference();
                newEvent.WwiseObjectReference.objectName = eventName;
                newEvent.WwiseObjectReference.id = eventId;
                return newEvent;
            }
        }
    }
}
