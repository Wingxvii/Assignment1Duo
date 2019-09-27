using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //list of all buildings
    private Stack<Building> allBuildings = new Stack<Building>();

    //stack of undo and redo commands
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

    //Interfacing Functions
    public void OnSelectContent() {

    }

    public void OnInitContent()
    {

    }
    public void OnDeinitContent()
    {

    }
    public void OnDeployContent()
    {

    }


    //undoredo
    public void OnUndo() {

    }

    public void OnRedo() {

    }


    //Button Functions
    public void Place() {

    }
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
}
