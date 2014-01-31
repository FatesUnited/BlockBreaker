/// <summary>
/// BrickScript.cs
/// 1/30/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control brick interaction
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour 
{
	// Use this for initialization
	void Start() 
	{

	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		
	} // end Update()

	void OnCollisionEnter(Collision col)
	{
		Destroy(gameObject);
	} // end OnCollisionEnter(Collision)
} // end BrickScript
