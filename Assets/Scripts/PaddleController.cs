/// <summary>
/// PaddleController.cs
/// 1/30/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class for the player to be able to control the paddle.
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// Get player input and move paddle.
/// Paddle is restricted to X-axis movement and does not change Y-position.
/// </summary>

using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour 
{
	public float maxSpeed = 500; // Max speed of the paddle
	public float speed = 300; // Default speed of the paddle
	public float ypos = 5;

	// Use this for initialization
	void Start() 
	{
		maxSpeed = 500; 
		speed = 300; 

		this.ypos = this.transform.position.y;
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 0);

		float xpos = this.transform.position.x;
		
		this.transform.position = new Vector3 (xpos, ypos, 0);
	} // end Update()

	// Move the player
	void FixedUpdate() 
	{
		float move = Input.GetAxis ("Horizontal");

		rigidbody2D.velocity = new Vector2(move * speed, 0);
	} // end FixedUpdate()
	
} // end PaddleController
		                      