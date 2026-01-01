using System;
using HarmonyLib;
using MTM101BaldAPI.Reflection;
using SuggestionPack.Internal.Storage;

namespace SuggestionPack.Patches
{
	[HarmonyPatch(typeof(EnvironmentController))]
	public class EnvPatch
	{
		[HarmonyPatch("Update")]
		static void UpdPrefix(EnvironmentController __instance) {
			if (PrefabCache.pickupPrefab == null) return;
			PrefabCache.pickupPrefab = __instance.ReflectionGetVariable("pickupPre") as Pickup;
		}
	}
}
