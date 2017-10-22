// animation code borrowed from https://docs.unity3d.com/Manual/AnimationParameters.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	private bool locked = true;

	// Create a boolean value called "opening" that can be checked in Update() 
	private bool opening = false;

	// public Animator DoorRaise;
	Animator animator;


	void Start() {
		animator = GetComponent<Animator>();
	}

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up

	}

	public void Unlock() {
		// You'll need to set "locked" to false here
		locked = false;			
		opening = true;

	}	

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if ((locked == false) && (opening == true)) {
			animator.SetBool ("opening", opening);
		} else {
			Debug.Log ("Locked!");
		}
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }


}
