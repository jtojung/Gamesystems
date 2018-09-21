using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon {
    
    public override void Attack()
    {
        // Instantiate a new bullet from prefab "bullet"
        GameObject clone = Instantiate(projectile);
        clone.transform.position = spawnPoint.position;
        clone.transform.rotation = spawnPoint.rotation;
        // Get the component from the new bullet
        Projectile newBullet = clone.GetComponent<Projectile>();
        // tell the bullet to fire
        newBullet.Fire(transform.forward);
    }
        
}
