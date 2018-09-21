using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable {
    public bool isOpen = false;
    public Animator anim;

	// Use this for initialization
	public override void Interact()
    {
        isOpen = !isOpen; // Toggle isOpen
        anim.SetBool("IsOpen", isOpen); //Animate door
    }
}
