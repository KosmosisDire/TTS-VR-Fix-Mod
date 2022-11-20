using BepInEx;
using UnityEngine;

namespace VRImprovements;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("Tabletop Simulator.exe")]
public class Plugin : BaseUnityPlugin
{
    Transform floor;


    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void Update()
    {
        // hide VR floor
        if (!floor)
        {
            floor = GameObject.Find("[VR]/[Static]/Floor").transform;
            floor.GetComponent<MeshRenderer>().enabled = false;
        }
        
    }
}
