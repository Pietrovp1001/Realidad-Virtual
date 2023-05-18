using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuertaGases : MonoBehaviour
{
    [SerializeField] private GameObject leftDoor, rightDoor;
    public int[] completedGas;

    void Update() {
        for (int i = 0; i < completedGas.Length; i++) {
            if (completedGas[i] == 0) {
                break;
            } else {
                OpenDoors();
                for (int j = 0; j < completedGas.Length; j++) {
                    completedGas[j] = 0;
                }
            }
        }
    }

    private void OpenDoors() {
        LeanTween.moveLocalX(leftDoor, 28.5f, 2f).setEaseInSine();
        LeanTween.moveLocalX(rightDoor, 34.5f, 2f).setEaseInSine();
    }
}
