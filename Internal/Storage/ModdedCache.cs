/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/1/2026
 * Time: 5:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MTM101BaldAPI;

namespace SuggestionPack.Internal.Storage
{
	/// <summary>
	/// Description of ModdedCache.
	/// </summary>
	public class ModdedCache
	{
		public static Dictionary<string, ItemObject> items = new Dictionary<string, items>();
		
		public static Dictionary<string, Sticker> stickers = new Dictionary<string, Sticker>();
		
		public static Dictionary<string, ExtendedStickerData> extendedStickerDatas = new Dictionary<string, ExtendedStickerData>();
		
	}
}
