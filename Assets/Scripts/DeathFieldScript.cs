/// <summary>
/// DeathFieldScript.cs
/// 1/31/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control when the ball dies
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class DeathFieldScript : MonoBehaviour 
{
	// Use this for initialization
	void Start() 
	{

	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		
	} // end Update()

	void OnTriggerEnter(Collider otherCol)
	{
		BallScript ballScript = otherCol.GetComponent<BallScript>();

		if (ballScript)
		{
			ballScript.Die();
		}
	}
	
} // end DeathFieldScript
