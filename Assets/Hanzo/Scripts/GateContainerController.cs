﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateContainerController : MonoBehaviour
{
    // public BoxCollider[] gates;

   
    
    public void CloseGate()
    {
        // foreach (var g in gates)
        // {
        //     g.enabled = false;
        // }
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) != null)
            {
                transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
