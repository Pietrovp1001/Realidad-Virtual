using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaCorrectaReto2 : MonoBehaviour
{
    public GameObject canvas;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BolaCorrecta"))
        {
            LeanTween.moveY(canvas.GetComponent<RectTransform>(), 0.6f, 0.2f).setEaseOutBounce();
            Debug.Log("Bola correcta");
        }
    }
}
