using System;
using SuggestionPack.Internal.Storage;
using SuggestionPack.Internal.Interfaces;
using UnityEngine;

namespace SuggestionPack.Internal.Stickers.Upgraders
{
	public class StickerStacker : INonItemPickup
	{
		public Pickup basePickup;
		
		public int maxStacks;
		
		public bool glued;
		
		public StickerStackerVariant Variant { get; private set; }
		
		void PickupInit() {
			Pickup p = UnityEngine.Object.Instantiate<Pickup>(PrefabCache.pickupPrefab, Vector3.zero);
		}
		
		public void SetAsVariant(StickerStackerVariant variant) {
			Variant = variant;
		}
		
	}
}
