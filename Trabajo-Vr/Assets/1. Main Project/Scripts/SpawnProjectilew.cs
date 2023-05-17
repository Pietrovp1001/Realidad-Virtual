using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
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


    public void booleanacton()
    {
        isShooting = true;
        currentChargeTime = 0.0f;
        Debug.Log("Cargando, tiempo:" + currentChargeTime);
    }
    
    public void booleanactoff()
    {
        isShooting = false;
        Debug.Log("Disparo cancelado");
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
                Debug.Log("disparao");
                isShooting = false;
            }
        }
    }

    private void spawnVfx ()
    {

        if (firepoint != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, firepoint.transform.position, quaternion.identity);
        }
        else
        {
            Debug.Log("no fire point");
        }
    }


}
