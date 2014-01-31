/// <summary>
/// PaddleScript.cs
/// 1/31/2014
/// Tom "Tribeman" Phillips
/// [Fates United]
/// 
/// Class to control Paddle movement and interaction
/// This was made for my UIC CS 426 - Video Game Design course.
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour 
{
	// Fields
	float speed = 20f;
	public GameObject ballPrefab;
	GameObject attachBall = null;
	int lives = 4;
	GUIText gui_lives;
	int score = 0;

	// Use this for initialization
	void Start() 
	{
		gui_lives = GameObject.Find ("GUI_Lives").GetComponent<GUIText>();
		Spawn();
	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		// Move left and right
		transform.Translate(20f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);

		// Fire the ball
		if (attachBall)
		{
			Rigidbody ballRigid = attachBall.rigidbody;
			ballRigid.position = transform.position + new Vector3 (0, .75f, 0);

			// Spacebar or the Y button
			if (Input.GetButtonDown("Jump"))
			{
				ballRigid.isKinematic = false;
				ballRigid.AddForce(300f * Input.GetAxis("Horizontal"), 300f, 0);
				attachBall = null;
			}
		}
	} // end Update()

	// FixedUpdate
	void FixedUpdate()
	{

	} // end FixedUpdate()

	// Checks for collision of the ball with the paddle and applies a force relative to where the ball hit
	void OnCollisionEnter(Collision col)
	{
		foreach (ContactPoint contact in col.contacts)
		{
			// This is the paddle's contact point
			if (contact.thisCollider == collider)
			{
				float loc = contact.point.x - transform.position.x;

				contact.otherCollider.rigidbody.AddForce(300f * loc, 0, 0);
			}
		}
	} // end OnCollisionEnter(Collision)

	// Creates a new ball on the paddle
	public void Spawn()
	{
		if (ballPrefab == null)
		{
			Debug.Log ("Link the ball prefab to the paddle in the inspector");
			return;
		}

		attachBall = ((GameObject)Instantiate (ballPrefab, transform.position + new Vector3 (0, .75f, 0), Quaternion.identity));

		lives--;

		gui_lives.text = "LIVES: " + lives;
	} // end Spawn()

	void OnGUI()
	{
		GUI.Label (new Rect (0, 10, 100, 100), "awoefijawfeoiawefoijawefoijawefiowjw");
	} // end OnGUI()
	
} // end PaddleScript
