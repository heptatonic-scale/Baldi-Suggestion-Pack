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
using MTM101BaldAPI.Registers;
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
			
			LoadingEvents.RegisterOnAssetsLoaded(Info, Preload(), LoadingEventOrder.Pre);
		}
		
		IEnumerator Preload() {
			yield return 3;
			yield return "Preloading...";
			
			yield break;
		}
	}
}