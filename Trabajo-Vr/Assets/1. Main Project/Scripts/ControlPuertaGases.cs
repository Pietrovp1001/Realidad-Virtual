using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuertaGases : MonoBehaviour
{
    [SerializeField] private GameObject leftDoor, rightDoor;
    public int[] completedGas;
    public bool oxigenCompleted, nitrogenCompleted, carbonoCompleted;
    public bool puertaAbierta = false;

    void Update()
     {
         if (oxigenCompleted && nitrogenCompleted && carbonoCompleted && puertaAbierta)
         {
             OpenDoors();
         }
     }

    private void OpenDoors() 
    {
        puertaAbierta = true;
        LeanTween.moveLocalX(leftDoor, 28.5f, 2f).setEaseInSine();
        LeanTween.moveLocalX(rightDoor, 34.5f, 2f).setEaseInSine();
    }
}
