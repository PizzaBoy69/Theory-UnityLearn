using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int unitOfProduction;
    public int totalProduction = 0;
    public float prodRate = 1f;
    private float checkRate = 0f;

    // Start is called before the first frame update
    private void Update()
    {
    }
    public virtual void Producing()
    {
        if (Time.time > checkRate)
        {
            checkRate = Time.time + prodRate;
            totalProduction += unitOfProduction;
        }
    }
}
