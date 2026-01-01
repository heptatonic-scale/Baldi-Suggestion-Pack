
using System;
using UnityEngine;
using SuggestionPack.Internal.Interfaces;

namespace SuggestionPack.Internal.Items.Bases
{
	// Borrowed code, might ask later
	public class MultipleUseItem : Item, IMultipleUseItem
	{
		[SerializeField]
		protected int uses;
		[SerializeField]
		protected ItemObject[] versions;
		
		protected bool ReturnItemOnUse() {
			if (uses > 0) {
				pm.itm.SetItem(versions[uses - 1], pm.itm.selectedItem);
				return false;
			}
			return true;
		}
		
		public void Init(params ItemObject[] v) {
			versions = v;
			uses = v.Length;
			for(int a = 0; a < versions.Length; a++) {
				BaseMultipleUseItem mui = (BaseMultipleUseItem)versions[a].item;
				mui.versions = v;
				mui.uses = a;
			}
		}
		
		
	}
}
