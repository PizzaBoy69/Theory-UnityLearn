using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankScript : Building
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Producing();
    }

    public override void Producing()
    {
        unitOfProduction = 2;
        base.Producing();
    }
}