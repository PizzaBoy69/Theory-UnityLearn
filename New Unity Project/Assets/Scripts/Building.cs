using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private UserControl2 userControl2Script;
    private string buildingName;

    private void Start()
    {
        userControl2Script = GameObject.Find("Selection Tool").GetComponent<UserControl2>();
    }

    public virtual void printBuilding()
    {
        var meno = gameObject.name;
        if (meno = userControl2Script.objectName) { }
        Debug.Log("Selected building is: " + buildingName);
    }

}
