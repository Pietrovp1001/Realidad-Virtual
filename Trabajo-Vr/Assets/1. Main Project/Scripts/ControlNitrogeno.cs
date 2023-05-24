using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNitrogeno : MonoBehaviour
{
    [SerializeField] private int gasLevel;
    [SerializeField] private int gasIndex;
    ControlPuertaGases controlPuertaGases;
    private int[] angleValue = {0, 28, 54, 84, 114};

    void Start() 
    {
        controlPuertaGases = GameObject.FindGameObjectWithTag("Oxigeno").GetComponent<ControlPuertaGases>();
    }

    public void SetOxigenValue(float value)
    {
        for (int i = 0; i < angleValue.Length; i++) {
            if (value == 0) {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            } else if (value == i) {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angleValue[i]));
            } else if (value == -i) {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angleValue[i]));
            }
        }

        if (gasLevel == value) {
            controlPuertaGases.nitrogenCompleted = true;
        }
    }
}
