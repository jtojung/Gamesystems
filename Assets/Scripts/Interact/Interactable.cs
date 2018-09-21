using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    // Use this for initialization
    public virtual void Interact()
    {
        print("Interactable base class called!");
    }
}