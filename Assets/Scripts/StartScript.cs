/// <summary>
/// StartScript.cs
/// 1/31/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to begin the game
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour 
{
	// Use this for initialization
	void Start() 
	{
		
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Application.LoadLevel("Level1");
		}
		//Debug.Log ("Button pressed: " + Input.GetButtonDown("Fire1"));
	} // end Update()

} // end StartScript
