using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public int lifePoints = 3;
    public Animations animations;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            lifePoints--;
            animations.AlienHit();

            if (lifePoints <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        GetComponent<Collider>().enabled = false;
        animations.AlienDeath();
    }
}
