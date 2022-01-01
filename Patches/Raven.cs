using HarmonyLib;
namespace NoTips.Patches {

	[HarmonyPatch(typeof(Raven), "Spawn")]

	public class Raven_Spawn_Patch {
		[HarmonyPrefix]
		internal static bool Prefix(Raven __instance, Raven.RavenText text, bool forceTeleport) {
			if (text.m_key.Length > 0 && !Player.m_localPlayer.HaveSeenTutorial(text.m_key)) {
				Player.m_localPlayer.SetSeenTutorial(text.m_key);
			}
			return false;
		}
	}

}