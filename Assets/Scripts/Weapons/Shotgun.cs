using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public int pallets = 6;
    

    public override void Attack()
    {
        //store forwad direction of player
        Vector3 direction = transform.forward;
        // Calculate spread by using range
        Vector3 spread = Vector3.zero;
        // offset on local Y
        spread += transform.up * Random.Range(-accuracy, accuracy);
        // offset on local x
        spread += transform.right * Random.Range(-accuracy, accuracy);
        // Instantiate a new bullet from prefab "projectile"
        GameObject clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        // Get the component from the new bullet
        Bullet newBullet = clone.GetComponent<Bullet>();
        // tell the bullet to fire
        newBullet.Fire(direction + spread);
    }
}


