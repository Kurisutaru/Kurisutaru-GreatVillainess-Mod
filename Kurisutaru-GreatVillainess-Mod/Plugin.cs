using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace KuriGreatVillainessMod;

[BepInPlugin(KuriModInfo.PLUGIN_GUID, KuriModInfo.PLUGIN_NAME, KuriModInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static ManualLogSource Logger = null!;

    public override void Load()
    {
        //Load Config
        ConfigManager.Initialize(this);

        // Plugin startup logic
        Logger = Log;
        Logger.LogInfo($"Plugin {KuriModInfo.PLUGIN_NAME} is loaded!");
        
        var harmony = new Harmony(KuriModInfo.PLUGIN_GUID);
        
        // Debug: Log all patches being applied
        if (ConfigManager.ModEnabled.Value)
        {
            Logger.LogInfo("Mod Enabled !");
            harmony.PatchAll();
        }
        else
        {
            Logger.LogInfo("Mod Disabled !");
        }
            
        // List all patched methods
        var patchedMethods = harmony.GetPatchedMethods().ToList();
        Logger.LogInfo($"Total patched methods: {patchedMethods.Count}");
            
        foreach (var method in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {method.DeclaringType?.Name}.{method.Name}");
        }
    }
}