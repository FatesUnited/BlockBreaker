/// <summary>
/// BrickScript.cs
/// 1/31/2014
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
	// Fields
	public int pointVal = 100;
	static int numBricks = 0;
	public int hitPoints = 1;

	// Use this for initialization
	void Start() 
	{
		numBricks++;
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		
	} // end Update()

	// Detects when collisions are made
	void OnCollisionEnter(Collision col)
	{
		hitPoints--;
		if (hitPoints <= 0)
		{
			Die();
		}
	} // end OnCollisionEnter(Collision)

	// Kills the brick
	void Die()
	{
		Destroy(gameObject);

		PaddleScript paddleScript = GameObject.Find("Paddle").GetComponent<PaddleScript>();
		paddleScript.AddScore(pointVal);
		
		//GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
		numBricks--;
		//Debug.Log (numBricks);
		if (numBricks <= 0)
		{
			// Load new level
			if (Application.loadedLevelName == "Level1")
				Application.LoadLevel("Level2");
			if (Application.loadedLevelName == "Level2")
				Application.LoadLevel("GameOver");
			if (Application.loadedLevelName == "LevelPKMN")
				Application.LoadLevel("GameOver");
		}
	} // end Die()

} // end BrickScript
