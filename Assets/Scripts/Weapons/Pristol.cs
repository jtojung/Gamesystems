using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pristol : Weapon {


    public override void Attack()
    {


        // Instantiate a new bullet from prefab "bullet"
        GameObject clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        // Get the component from the new bullet
        Projectile newBullet = clone.GetComponent<Projectile>();
        // tell the bullet to fire
        newBullet.Fire(transform.forward);
    }
        
}
