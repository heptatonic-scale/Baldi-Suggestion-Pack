using System;

namespace SuggestionPack.Internal.Stickers.Upgraders
{
	public enum StickerStackerVariant
	{
		/// <summary>
		/// Basically just nothing.
		/// </summary>
		Nothing,
		/// <summary>
		/// Can make the player be able to stack 2 stickers with the same sticker.
		/// </summary>
		StackLvl1,
		/// <summary>
		/// Can make the player be able to stack 3 stickers with the same sticker.
		/// </summary>
		StackLvl2,
		/// <summary>
		/// Can make the player be able to stack 2 stickers with the same sticker and be glued.
		/// </summary>
		GluedStackLvl1,
		/// <summary>
		/// Can make the player be able to stack 2 stickers but can only put the other one a random sticker.
		/// </summary>
		RandomStackLvl1,
		/// <summary>
		/// UNUSED: Can make the player be able to stack 1 with an item inside the sticker (Item will be saved).
		/// </summary>
		SaveStack,
	}
}
