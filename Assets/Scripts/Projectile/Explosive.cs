using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : Projectile
{
    public float explosionRadius = 5f;
    public GameObject explosion;
    // Use this for initialization
    public override void OnCollisionEnter(Collision col)
    {
        string tag = col.collider.tag;
        if(tag !="Player" && tag != "Weapon")
        {
            print(col.collider.tag);
            print(col.collider.name);
            Effects(); //Spawns a particle
            Explode(); // Deals damage to surrounding enemies
        }
    }
    void Effects()
    {
        Instantiate(explosion, transform.position, transform.rotation);

    }
    void Explode()
    {
        // try getting the enemy component
        Collider[] hits = Physics.OverlapSphere(transform.position, explosionRadius);
        //Loop through everything we hit
        foreach (var hit in hits)
        {
            //Try getting the enemy component
            Enemy e = hit.GetComponent<Enemy>();
            // if we hit an enemy
            if(e)
            {
                //Note(Manny): You can calculate a falloff damage here
                //Deal damage to the enemy
                e.DealDamage(damage);
            }
        }
    }
}
