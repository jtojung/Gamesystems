﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 100;
    public float speed = 5f;
    public float range = 50f;
    public float rateOfFire;
    public GameObject impact;
    public Rigidbody rigid;

    public virtual void Fire(Vector3 direction)
    {
        rigid.AddForce(direction * speed, ForceMode.Impulse);

    }
    public virtual void OnCollisionEnter(Collision collision)
    {

    }
}
