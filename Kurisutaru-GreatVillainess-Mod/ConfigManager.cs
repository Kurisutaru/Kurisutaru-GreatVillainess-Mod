using System.ComponentModel.DataAnnotations;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;

namespace KuriGreatVillainessMod;

public static class ConfigManager
{
    public static ConfigEntry<bool> ModEnabled = null!;
    public static ConfigEntry<int> ExpMultiplier = null!;
    public static ConfigEntry<int> BondMultiplier = null!;
    public static ConfigEntry<double> CharacterStatusMultiplier = null!;
    public static ConfigEntry<bool> ShipSkillFlatEnergyCost = null!;
    public static ConfigEntry<bool> ShipSkillNoEnergyCost = null!;
    public static ConfigEntry<bool> ShipSkillDoubleRange = null!;

    public static void Initialize(BasePlugin main)
    {
        ModEnabled = main.Config.Bind("!Main",
            "Enable",
            true,
            new ConfigDescription("Enable Mod"));
        ExpMultiplier = main.Config.Bind("Gameplay",
            "ExpMultiplier",
            1,
            new ConfigDescription("Multiply your gained EXP")
        );
        BondMultiplier = main.Config.Bind("Gameplay",
            "BondMultiplier",
            1,
            new ConfigDescription("Multiply your Bond")
        );
        CharacterStatusMultiplier = main.Config.Bind("Gameplay",
            "CharacterStatusMultiplier",
            1d,
            new ConfigDescription("Multiply your character status")
        );
        ShipSkillFlatEnergyCost  = main.Config.Bind("Gameplay",
            "ShipSkillFlatEnergyCost",
            false,
            new ConfigDescription("Make all ship skill 1 energy cost")
        );
        ShipSkillNoEnergyCost  = main.Config.Bind("Gameplay",
            "ShipSkillNoEnergyCost",
            false,
            new ConfigDescription("Make all ship skill 0 energy cost")
        );
        ShipSkillDoubleRange  = main.Config.Bind("Gameplay",
            "ShipSkillDoubleRange",
            false,
            new ConfigDescription("Double your ship skill range")
        );
    }
}