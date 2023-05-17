using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Rule;

public class FusiblesDesconectados : MonoBehaviour
{
    public Renderer checkFusible;
    public Material materialFusible;
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fusible"))
        {
            checkFusible.material = materialFusible;
            Debug.Log("Fusible DESCONECTADO");
            Reto1FusiblesManager.instance.fusiblesDesconectados++;
            ///other.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
