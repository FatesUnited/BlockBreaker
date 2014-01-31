/// <summary>
/// BallScript.cs
/// 1/31/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control Ball movement and interaction
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour 
{
	// Use this for initialization
	void Start() 
	{
		//rigidbody.AddForce (0, 300f, 0);
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{

	} // end Update()

	public void Die()
	{
		Destroy(gameObject);

		GameObject paddleObject = GameObject.Find("Paddle");
		PaddleScript paddleScript = paddleObject.GetComponent<PaddleScript>();
		paddleScript.Spawn();
	}

} // end BallScript
