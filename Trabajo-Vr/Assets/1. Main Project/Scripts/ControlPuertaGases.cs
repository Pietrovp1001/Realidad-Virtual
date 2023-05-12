using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuertaGases : MonoBehaviour
{
    [SerializeField] private Transform[] puertas;
    Vector3 offset = new Vector3(2, 0, 0); 
    public int completedGas = 0;

    void Update() {
        if (completedGas >= 3) {
            OpenDoors();
            completedGas = 0;
        }
    }

    private void OpenDoors() {
        puertas[0].position -= offset;
        puertas[1].position += offset;
    }
}
