using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this uses the factory method
enum BuildingEnum
{
    RedBuilding,
    BlueBuildinng,
    GreenBuilding,
    YellowBuilding,
    None,
}


public abstract class Building
{
    public Building() {
        id = ++totalBuildings;
    }

    public static int totalBuildings { get; private set; }
    public int id { get; private set; }
    protected int level { get; set; }

    public abstract void Build(Vector3 pos);
}


public class RedBuilding : Building {

    public RedBuilding(Vector3 pos):base() {
        level = 0;
        Build(pos);
    }

    public override void Build(Vector3 pos) {

    }
}

public class BlueBuilding : Building
{
    public BlueBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }
    public override void Build(Vector3 pos)
    {

    }

}

public class GreenBuilding : Building
{
    public GreenBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }

    public override void Build(Vector3 pos)
    {

    }

}

public class YellowBuilding : Building
{
    public YellowBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }

    public override void Build(Vector3 pos)
    {

    }

}