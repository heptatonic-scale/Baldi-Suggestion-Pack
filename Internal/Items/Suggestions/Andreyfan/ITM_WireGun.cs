/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/1/2026
 * Time: 7:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SuggestionPack.Internal.Items.Bases;

namespace SuggestionPack.Internal.Items.Suggestions.Andreyfan
{
	public class ITM_WireGun : MultipleUseItem
	{
		public override bool Use(PlayerManager pm)
		{
			pm.plm.Entity.SetGrounded(false);
		}
	}
}
