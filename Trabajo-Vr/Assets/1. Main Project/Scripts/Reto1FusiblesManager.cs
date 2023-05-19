using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto1FusiblesManager : MonoBehaviour
{
    public static Reto1FusiblesManager instance;
    public int fusiblesConectados = 0;
    public int fusiblesDesconectados = 0;
    public Renderer checkTodosFusiblesConectados1, checkTodosFusiblesConectados2, checkTodosFusiblesConectados3;
    public Material materialVerde;
    public GameObject leftDoor, rightDoor;
    public bool sePuedeAbrir = true;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
      //OpenDoors();
    }

    private void Update()
    {
        if (fusiblesConectados == 3)
        {
            checkTodosFusiblesConectados1.material = materialVerde;
        }
        if (fusiblesConectados == 6)
        {
            checkTodosFusiblesConectados2.material = materialVerde;
        }
        if (fusiblesConectados == 9)
        {
            checkTodosFusiblesConectados3.material = materialVerde;
        }
        if (fusiblesDesconectados == 4 && sePuedeAbrir && fusiblesConectados == 9)
        {
            OpenDoors();
        }
    }

    public void OpenDoors()
    {
        LeanTween.moveLocalZ(leftDoor, 30f, 2f).setEaseInSine();
        LeanTween.moveLocalZ(rightDoor, 24f, 2f).setEaseInSine();
        sePuedeAbrir = false;
    }
}
