using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    //list of all buildings
    private List<Building> allBuildings = new List<Building>();

    //stack of undo and redo commands (NOTE: THESE ALREADY HAVE OBJS ATTACHED TO THEM)
    private Stack<ICommand> _Undocommands = new Stack<ICommand>();
    private Stack<ICommand> _Redocommands = new Stack<ICommand>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    #region Interfacing Functions
    //Interfacing Functions
    public void OnSelectContent() {

    }
    public void Place()
    {

    }
    #endregion

    #region UndoRedo
    //undoredo
    public void OnUndo() {
        if(_Undocommands.Count != 0){
            
        }
    }

    public void OnRedo() {

    }
    #endregion  

    #region Buttton Functions
    //Button Functions

    public void Upgrade()
    {

    }
    public void Delete()
    {

    }
    public void Save()
    {

    }
    public void Load()
    {

    }
    #endregion  

    //command pattern
    public void ExecuteCommand(BuildingActions command, Building building) {
        //clear redo
        if (_Redocommands.Count != 0) { _Redocommands.Clear(); }

        switch (command) {
            case BuildingActions.Place:
                _Undocommands.Push(new PlaceBuilding(building));
                break;


        }

    }

    //factory pattern
    public void CreateBuilding(BuildingEnum buildingType, Vector3 position) {
        switch (buildingType) {
            case BuildingEnum.RedBuilding:
                allBuildings.Add(new RedBuilding(position));
                break;
            case BuildingEnum.BlueBuildinng:
                allBuildings.Add(new BlueBuilding(position));
                break;
            case BuildingEnum.GreenBuilding:
                allBuildings.Add(new GreenBuilding(position));
                break;
            case BuildingEnum.YellowBuilding:
                allBuildings.Add(new YellowBuilding(position));
                break;
        }
    }
}

