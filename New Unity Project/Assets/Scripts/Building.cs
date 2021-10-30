using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public static string objectName { get; private set; }
    public virtual void printBuilding()
    {
        objectName = gameObject.name;
        Debug.Log("Selected building is: " + objectName);
        
    }

}
