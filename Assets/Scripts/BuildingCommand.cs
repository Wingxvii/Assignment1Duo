
using System.Collections;
using System.Collections.Generic;

public interface ICommand
{
    void ExecuteAction();
    void UnExecuteAction();
}

public enum BuildingActions {
    Place,
    Upgrade,
    Delete,
}


class PlaceBuilding : ICommand {
    private Building buildingElement;

    public PlaceBuilding(Building building) {

    }

    public void ExecuteAction() {

    }
    public void UnExecuteAction()
    {

    }
}

class UpgradeBuilding : ICommand
{
    private Building buildingElement;

    public UpgradeBuilding(Building building) {
    }

    public void ExecuteAction()
    {

    }
    public void UnExecuteAction()
    {

    }
}

class DeleteBuilding : ICommand
{
    private Building buildingElement;

    public DeleteBuilding(Building building) {

    }
    public void ExecuteAction()
    {

    }
    public void UnExecuteAction()
    {

    }
}