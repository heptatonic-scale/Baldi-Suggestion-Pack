/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/1/2026
 * Time: 2:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using MTM101BaldAPI;
using MTM101BaldAPI.ObjectCreation;
using SuggestionPack.Internal.Storage;
using SuggestionPack.Internal.Items.Upgraders;

namespace SuggestionPack
{
	[BepInPlugin("heptatonic.bbplus.sgpack", "Suggestion Pack", "1.0.0")]
	public class PackBasePlugin : BaseUnityPlugin
	{
		void Awake() {
			Harmony h = new Harmony(base.Info.Metadata.GUID);
			h.PatchAllConditionals();
		}
		
		IEnumerator Preload() {
			yield return 3;
			yield return "Preloading...";
			ModdedCache.items.Add("Itm_StickerStacker", new ItemBuilder);
			ModdedCache.stickers.Add("StickerStacker", EnumExtensions.ExtendEnum<Sticker>("StickerStacker"));
			ModdedCache.extendedStickerDatas.Add("StickerStackerData", new StickerBuilder<ExtendedStickerData>(Info).SetEnum("StickerStacker").SetDuplicateOddsMultiplier(0.5f).Build());
			yield break;
		}
	}
}