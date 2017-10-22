// Code help from runeskape125: http://answers.unity3d.com/questions/1301342/restarting-the-scene-when-button-is-pressed.html

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
		// Reset the scene when the user clicks the sign post. Adapted from ChangeScene.cs
		//SceneManager.LoadScene ("A Maze.unity");
		Application.LoadLevel(Application.loadedLevel);
		Debug.Log ("My method was called!");
	}
}
