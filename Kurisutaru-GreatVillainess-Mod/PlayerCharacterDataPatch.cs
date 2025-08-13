using Bharat;
using HarmonyLib;

namespace KuriGreatVillainessMod;

[HarmonyPatch]
public class PlayerCharacterDataPatch
{
    private static double _characterStatusMultiplier = ConfigManager.CharacterStatusMultiplier.Value;

    [HarmonyPatch(typeof(PlayerCharacterData), nameof(PlayerCharacterData.GetAttack))]
    [HarmonyPostfix]
    public static void CharacterStatusDataGetAttack(ref int __result)
    {
        if (__result > 0 && _characterStatusMultiplier > 1)
        {
            __result = (int)Math.Round(__result * _characterStatusMultiplier);
        }
    }

    [HarmonyPatch(typeof(PlayerCharacterData), nameof(PlayerCharacterData.GetDefense))]
    [HarmonyPostfix]
    public static void PlayerCharacterDataGetDefense(ref int __result)
    {
        if (__result > 0 && _characterStatusMultiplier > 1)
        {
            __result = (int)Math.Round(__result * _characterStatusMultiplier);
        }
    }

    [HarmonyPatch(typeof(PlayerCharacterData), nameof(PlayerCharacterData.GetMaxHP))]
    [HarmonyPostfix]
    public static void PlayerCharacterDataGetMaxHp(ref int __result)
    {
        if (__result > 0 && _characterStatusMultiplier > 1)
        {
            __result = (int)Math.Round(__result * _characterStatusMultiplier);
        }
    }

    [HarmonyPatch(typeof(PlayerCharacterData), nameof(PlayerCharacterData.GetSpeed))]
    [HarmonyPostfix]
    public static void PlayerCharacterDataGetSpeed(ref int __result)
    {
        if (__result > 0 && _characterStatusMultiplier > 1)
        {
            __result = (int)Math.Round(__result * _characterStatusMultiplier);
        }
    }
}