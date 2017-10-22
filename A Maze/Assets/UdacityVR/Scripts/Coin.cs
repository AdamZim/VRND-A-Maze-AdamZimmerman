// help but not verbatim copying from https://github.com/ErickSimoes/maze_vr/blob/master/Assets/Udacity/Scripts/Coin.cs
// and Eric5h5 from http://answers.unity3d.com/questions/123877/instantiate-a-rotated-object.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	//Create a reference to the CoinPoofPrefab and particular coin (?)
	public GameObject CoinPoofPrefab;

	private bool clicked = false;

	public int CoinCount;		// Count coins for scoreboard. Works! Does this var just float around the whole scene now? Hmm...

    public void OnCoinClicked() {
		clicked = true;
		CoinCount += 1;

		// Destroy this coin
		Destroy(gameObject);


		// Instantiate the CoinPoof Prefab where this coin is located. Adapted code from my birdmaker script. works!
		GameObject CoinPoof = (GameObject)Object.Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler(270, 0, 0));     // Rotate 90 around z should animate vertically. Thanks Eric5h5
	
    }
}
