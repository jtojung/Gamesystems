using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incendiary : Projectile
{
    public float dotDuration = 2f;

    // Use this for initialization
   
   public  override void OnCollisionEnter(Collision col)
    {
        Enemy e = col.collider.GetComponent<Enemy>();
        if(e)
        {
            // Disable bullet effect
           Burn(e);
        }
    }
    IEnumerator Burn(Enemy enemy)
    {
        yield return new WaitForSeconds(dotDuration);
        enemy.DealDamage(damage);
        //Start it again
        StartCoroutine(Burn(enemy));


    }
}