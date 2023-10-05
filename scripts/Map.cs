using Godot;
using System;
using System.Linq;
using StrategyGame.scripts;

public class Map : Node
{
	public Tile[] AllTiles;
	public Tile[] TilesWithBuildings;
	public float TileSize = 64.0f;

	public Tile GetTileAtPosition(Vector2 position)
	{
		return AllTiles.FirstOrDefault(t => t.Position == position && t.HasBuilding == false);
	}

	public void DisableTileHighlights()
	{
		foreach (var t in AllTiles)
		{
			t.ToggleHighlight(false);
		}
	}

	public void HighlightAvailableTiles()
	{
		foreach (var t in TilesWithBuildings)
		{
			var northTile = GetTileAtPosition(t.Position + new Vector2(0f, TileSize));
			var southTile = GetTileAtPosition(t.Position + new Vector2(0f, -TileSize));
			var eastTile = GetTileAtPosition(t.Position + new Vector2(TileSize, 0f));
			var westTile = GetTileAtPosition(t.Position + new Vector2(-TileSize, 0f));

			if (northTile != null)
			{
				northTile.ToggleHighlight(true);
			}			
			if (southTile != null)
			{
				southTile.ToggleHighlight(true);
			}			
			if (eastTile != null)
			{
				eastTile.ToggleHighlight(true);
			}			
			if (westTile != null)
			{
				westTile.ToggleHighlight(true);
			}
		}
	}

}
