using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherScript : Building
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            printBuilding();
        }
    }

    public override void printBuilding()
    {
        if (UserControl2.selectedName == gameObject.name)
        {
            base.printBuilding();
        }
    }
}
