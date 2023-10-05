using Godot;
namespace StrategyGame.scripts
{
	public class Tile : Area2D
	{
		// is this the starting tile?
		// Base building will be placed here at start of game
		[Export()]
		public bool StartTile = false;

		// Do we have a building on this tile?
		public bool HasBuilding = false;
		// can we place a building on this tile?
		public bool CanPlaceBuilding = false;
		
		//Components
		public Sprite Highlight;
		public Sprite BuildingIcon;

		public override void _Ready()
		{
			Highlight = GetNode<Sprite>("Highlight");
			BuildingIcon = GetNode<Sprite>("BuildingIcon");
			
			AddToGroup("Tiles");
		}

		// turns on or off green highlight
		public void ToggleHighlight(bool toggle)
		{
			Highlight.Visible = toggle;
			CanPlaceBuilding = toggle;
		}

		public void PlaceBuilding(Texture buildingTexture)
		{
			HasBuilding = true;
			BuildingIcon.Texture = buildingTexture;
		}
		private void _on_Tile_input_event(object viewport, object @event, int shape_idx)
		{
			// Replace with function body.
		}
	}
}


