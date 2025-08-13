using Bharat;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace KuriGreatVillainessMod;

[HarmonyPatch]
public class DataCenterSetupPatch
{
    private static int _expMultiplier = ConfigManager.ExpMultiplier.Value;
    private static int _bondMultiplier = ConfigManager.BondMultiplier.Value;
    private static bool _shipSkillFlatEnergyCost = ConfigManager.ShipSkillFlatEnergyCost.Value;
    private static bool _shipSkillNoEnergyCost = ConfigManager.ShipSkillNoEnergyCost.Value;
    private static bool _shipSkillDoubleRange = ConfigManager.ShipSkillDoubleRange.Value;

    private static Il2CppReferenceArray<ShipSkillData> _shipSkillData = new(0);

    [HarmonyPatch(typeof(DataCenter), nameof(DataCenter.GetExperienceValue))]
    [HarmonyPostfix]
    public static void DataCenterGetExperienceValue(ref int __result)
    {
        if (__result > 0 && _expMultiplier > 1)
        {
            __result *= _expMultiplier;
        }
    }

    [HarmonyPatch(typeof(DataCenter), nameof(DataCenter.GetBondExperienceValue))]
    [HarmonyPostfix]
    public static void DataCenterGetBondExperienceValue(ref int __result)
    {
        if (__result > 0 && _bondMultiplier > 1)
        {
            __result *= _bondMultiplier;
        }
    }

    [HarmonyPatch(typeof(StreamingShip), nameof(StreamingShip.SetupSkills))]
    [HarmonyPrefix]
    public static void StreamingShipSetupSkills(StreamingShip __instance,
        ref Il2CppReferenceArray<ShipSkillData> availableSkills)
    {
        if (_shipSkillData.Length == 0)
        {
            foreach (var skill in availableSkills)
            {
                if (_shipSkillFlatEnergyCost)
                {
                    skill.EnergyCost = 1;
                }

                if (_shipSkillNoEnergyCost)
                {
                    skill.EnergyCost = 0;
                }

                if (_shipSkillDoubleRange)
                {
                    skill.SkillRange *= 2;
                }
            }

            _shipSkillData = availableSkills;
        }
        else
        {
            availableSkills = _shipSkillData;
        }
    }
    
}