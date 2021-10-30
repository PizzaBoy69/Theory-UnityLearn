using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherScript : Building // INHERITANCE
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            printBuilding(); // ABSTRACTON
        }
    }

    public override void printBuilding() // POLYMORPHISM
    {
        if (UserControl2.selectedName == gameObject.name)
        {
            base.printBuilding();
        }
    }
}
