/// <summary>
/// Ball.cs
/// 1/30/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control Ball movement and interaction
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// 
/// </summary>
/// 
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	public float minSpeed = 500; // Min speed of the ball
	public float maxSpeed = 1000; // Max speed of the ball
	public float speed = 750; // Default speed of the ball
	public float curSpeed = 0; // Current speed of the ball
	
	// Use this for initialization
	void Start() 
	{
		minSpeed = 500;
		maxSpeed = 1000; 
		speed = 7500; 

		rigidbody2D.AddForce(new Vector2(0, -speed));
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		
	} // end Update()
	
	// Move the ball
	void FixedUpdate() 
	{

	} // end FixedUpdate()
	
} // end Ball