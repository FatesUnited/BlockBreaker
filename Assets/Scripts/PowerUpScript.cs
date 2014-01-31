/// <summary>
/// PowerUpScript.cs
/// 1/31/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control power ups
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour 
{
	// Use this for initialization
	void Start() 
	{
		
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		
	} // end Update()

	// Detects Collisions
	void OnCollisionEnter(Collision col)
	{
		Destroy(gameObject);
	} // end OnCollisionEnter(Collision)
	
} // end PowerUpScript
