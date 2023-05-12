using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusibleCorrecto : MonoBehaviour
{
    
    
    public Renderer checkFusible;
    public Material materialFusible;
    
    public void ChangeMaterial()
    {
        checkFusible.material = materialFusible;
        Debug.Log("Hola si funciono amigo");
    }
}
