using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this uses the factory method
public enum BuildingEnum
{
    RedBuilding,
    BlueBuildinng,
    GreenBuilding,
    YellowBuilding,
    None,
}

public abstract class Building
{
    //creates and sets an id for each building
    public Building() {
        id = ++idtracker;
    }

    public static int idtracker { get; private set; }
    public int id { get; private set; }
    protected int level { get; set; }

    //build instantiates the object in the game scene
    public abstract void Build(Vector3 pos);
}

#region Red
public class RedBuilding : Building {

    public GameObject prefab = (GameObject)Resources.Load("prefabs/Red", typeof(GameObject));

    public RedBuilding(Vector3 pos):base() {
        level = 0;
        Build(pos);
    }
    public override void Build(Vector3 pos)
    {
        GameObject.Instantiate(prefab, pos, Quaternion.identity);
    }
}
#endregion 

#region Blue
public class BlueBuilding : Building
{
    public GameObject prefab = (GameObject)Resources.Load("prefabs/Blue", typeof(GameObject));

    public BlueBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }
    public override void Build(Vector3 pos)
    {
        GameObject.Instantiate(prefab, pos, Quaternion.identity);
    }

}
#endregion

#region Green
public class GreenBuilding : Building
{
    public GameObject prefab = (GameObject)Resources.Load("prefabs/Green", typeof(GameObject));

    public GreenBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }
    public override void Build(Vector3 pos)
    {
        GameObject.Instantiate(prefab, pos, Quaternion.identity);
    }

}
#endregion  

#region Yellow
public class YellowBuilding : Building
{
    public GameObject prefab = (GameObject)Resources.Load("prefabs/Yellow", typeof(GameObject));

    public YellowBuilding(Vector3 pos) : base()
    {
        level = 0;
        Build(pos);
    }
    public override void Build(Vector3 pos)
    {
        GameObject.Instantiate(prefab, pos, Quaternion.identity);
    }

}

#endregion