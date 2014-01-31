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
	// Fields
	float bounciness = 10;

	// Use this for initialization
	void Start() 
	{
		//rigidbody.AddForce (0, 300f, 0);
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{

		//ballRigid.AddForce(300f * Input.GetAxis("Horizontal"), 300f, 0);
	} // end Update()

	public void Die()
	{
		Destroy(gameObject);

		GameObject paddleObject = GameObject.Find("Paddle");
		PaddleScript paddleScript = paddleObject.GetComponent<PaddleScript>();
		paddleScript.LoseLife();
	}

	void OnCollisionEnter(Collision col)
	{
		foreach (ContactPoint contact in col.contacts)
		{
			if (col.gameObject.name != "Paddle") 
			{
				float loc = col.gameObject.transform.position.y - contact.point.y;

				this.rigidbody.AddForce(new Vector3(0, loc * bounciness + 3, 0));
			}
		}
	}

} // end BallScript
