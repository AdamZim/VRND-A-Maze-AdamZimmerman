using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoofPrefab;
	public Door door;    // not sure if this should be prefab. Made lower case thanks to Erick Simoes (see readme)

	// public bool locked = true; // Setting scene-wide lock condition. Shouldn't work because bools can't be scene-wide, only GameObject methods can.

	private bool KeyCollected = false; 

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		GameObject KeyPoof = (GameObject)Object.Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler (270, 0, 0));    

        // Call the Unlock() method on the Door
		door.Unlock();

		// Set the Key Collected Variable to true. Why? For Door... seems redundant, but ok.
		KeyCollected = true;
		        
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);

		Debug.Log ("Door should now be unlocked.");

		// gameObject.SetActive(false); // ??
    }

}
