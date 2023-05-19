using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator Puertaentrada1;
    public Animator Puertaentrada2;
    public Animator Puertasalida1;
    public Animator Puertasalida2;
    public Animator Alien;
    public bool isdead;

    private IEnumerator coroutine;

    [SerializeField] private float ScreamTime;
    

    private void Start()
    {
        coroutine = AlienReady();
    }


    public void armita()
    {
        Puertaentrada1.SetTrigger("Cerrado");
        Puertaentrada2.SetTrigger("Cerrado2");
    }


    public void botondeentrada()
    {
        Puertaentrada1.SetTrigger("Abierto");
        Puertaentrada2.SetTrigger("Abierto2");
        Puertasalida1.SetTrigger("Cerrado");
        Puertasalida2.SetTrigger("Cerrado2");
        Alien.SetTrigger("AlienOn");
        StartCoroutine("AlienReady");
    }

    private IEnumerator AlienReady()
    {
        while (!isdead)
        {
            yield return new WaitForSeconds(ScreamTime);
            Alien.SetTrigger("Scream");
        }
    }
    
    public void AlienHit()
    {
        Alien.SetTrigger("Hit");
    }
    
    public void AlienDeath()
    {
        Alien.SetTrigger("Death");
    }
}
