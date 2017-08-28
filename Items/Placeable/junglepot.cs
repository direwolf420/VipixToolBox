using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VipixToolBox.Items.Placeable
{
	public class junglepot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Pot");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 0;
			item.value = 2;
			item.createTile = mod.TileType("junglepottile");
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClayBlock, 4);
			recipe.AddIngredient(ItemID.MudBlock, 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
