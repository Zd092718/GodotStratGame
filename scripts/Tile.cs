using Godot;
namespace StrategyGame.scripts
{
	public class Tile : Area2D
	{
		[Export()]
		public bool StartTile = false;

		public bool HasBuilding = false;
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


