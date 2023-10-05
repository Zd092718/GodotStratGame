using Godot;
using System;
using StrategyGame.scripts;

public class Building
{
	public int type;
	public Texture iconTexture;
	public int prodResource;
	public int prodResourceAmount;
	public int upkeepResource = 0;
	public int upkeepResourceAmount;

	public Building(int type, Texture iconTexture, int prodResource, int prodResourceAmount, int upkeepResource, int upkeepResourceAmount)
	{
		this.type = type;
		this.iconTexture = iconTexture;
		this.prodResource = prodResource;
		this.prodResourceAmount = prodResourceAmount;
		this.upkeepResource = upkeepResource;
		this.upkeepResourceAmount = upkeepResourceAmount;
	}
};

public class BuildingData : Node
{
	public static Building Base = new Building(0, ResourceLoader.Load<Texture>("res://Assets/Sprites/Base.png"), 0, 0, 0, 0);
	public static Building Mine = new Building(1, ResourceLoader.Load<Texture>("res://Assets/Sprites/Mine.png"), 2, 1, 4, 1);
	public static Building Greenhouse = new Building(2, ResourceLoader.Load<Texture>("res://Assets/Sprites/Greenhouse.png"), 1, 1, 0, 0);
	public static Building SolarPanel = new Building(3, ResourceLoader.Load<Texture>("res://Assets/Sprites/SolarPanel.png"), 4, 1, 0, 0);

}
