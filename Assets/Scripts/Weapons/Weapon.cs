using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
*
*Task 1) Creat a Draw .io UML diagram for the Projectile system
* Details: Projectile system needs to following structure 
*                     Projectile
*                     /    |    \
*               Normal  Fire   Explosive
*   Variabls for each class
*   function for each class
* 
*Task 2) Player cannot shoot until the weapon is ready to fire
* Details: Refer to discord channel "GameSystem" for any resources on this task
* 
* 
*/

public abstract class Weapon : MonoBehaviour
{


    public Transform spawnPoint;
    public int damage = 100;
    public int ammo = 30;
    public float accuracy = 1f;
    public float range = 10f;
    public float rateOfFire = 5f;
    public GameObject projectile;
    protected int currentAmmo = 0;

    public abstract void Attack();

    // Use this for initialization
    public void Reload()
    {
        //reset currentAmmo
        currentAmmo = ammo;
    }
}
