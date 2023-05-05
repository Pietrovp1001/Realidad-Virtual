using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusibleCorrecto : MonoBehaviour
{
    
    public Renderer checkFusible;
    public void ChangeMaterial()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
