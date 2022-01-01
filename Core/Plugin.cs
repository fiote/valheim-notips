using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace NoTips {
	[BepInPlugin("fiote.mods.notips", "NoTips", "0.0.1")]

	public class NoTips : BaseUnityPlugin {
		private void Awake() {
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "fiote.mods.notips");
		}
	}
}