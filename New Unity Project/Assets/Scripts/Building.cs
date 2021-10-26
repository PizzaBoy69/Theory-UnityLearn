using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int unitOfProduction;
    public int totalProduction = 0;
    private float prodRate = 1f;
    private float checkRate = 0f;

    // Start is called before the first frame update
    private void Update()
    {
        Producing();
    }
    private void Producing()
    {
        if (Time.time > checkRate)
        {
            checkRate = Time.time + prodRate;
            totalProduction += unitOfProduction;
        }
    }
}
