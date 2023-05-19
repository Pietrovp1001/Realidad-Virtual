using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnProjectilew : MonoBehaviour
{
    [SerializeField] private float chargeTime = 2.0f;
    private bool isCharged = false;
    private bool isShooting = false;
    
    private float currentChargeTime = 0.0f;

    public GameObject firepoint;

    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private ParticleSystem charge;
    [SerializeField] private ParticleSystem shot;

    public changecolor color;


    public void booleanacton()
    {
        isShooting = true;
        Debug.Log("Cargando");
        charge.Play();
        color.ChangeColorShot();
    }
    
    public void booleanactoff()
    {
        color.ResetColor();
        isShooting = false;
        Debug.Log("Disparo cancelado");
        charge.Clear();
        currentChargeTime = 0.0f;
    }

    
    void Update()
    {
        if (isShooting)
        {
            currentChargeTime += Time.deltaTime;
            if (currentChargeTime >= chargeTime && !isCharged)
            {
                isCharged = true;
                spawnVfx();
                isShooting = false;
            }
        }
    }

    private void spawnVfx ()
    {

        if (firepoint != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, firepoint.transform.position, firepoint.transform.rotation);
            Debug.Log("disparao");
            currentChargeTime = 0.0f;
            isCharged = false;
            shot.Play();
            color.ResetColor();
        }
        else
        {
            Debug.Log("no fire point");
        }
    }


}
