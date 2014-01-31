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
	string[] str = new string[8];
	int pos2 = 0;
	bool pkmn = false;

	// Use this for initialization
	void Start() 
	{

	} // end Start()
	
	// Update is called once per frame
	void Update() 
	{
		if (Input.GetButtonDown("Fire1") && !pkmn)
		{
			Application.LoadLevel("Level1");
		}

		BULBASAUR ();

		Debug.Log (str [0]+str [1]+str [2]+str [3]+str [4]+str [5]+str [6]+str [7]);

		//Debug.Log ("Button pressed: " + Input.GetButtonDown("Fire1"));
	} // end Update()
	

	// checks for BULBASAUR
	void BULBASAUR()
	{
		if (Input.GetKeyDown ("joystick button 1") && pos2 == 0)
		{
			str [0] = "B";
			pos2++;
		}
		else if (Input.GetAxis("Vertical") > 0 && pos2 == 1)
		{
			str [1] = "U";
			pos2++;
		}
		else if (Input.GetKeyDown ("joystick button 4") && pos2 == 2)
		{
			str [2] = "LB";
			pos2++;
		}
		else if (Input.GetKeyDown ("joystick button 0") && pos2 == 3)
		{
			str [3] = "A";
			pos2++;
		}
		else if (Input.GetKeyDown ("joystick button 6") && pos2 == 4)
		{
			str [4] = "S";
			pos2++;
		}
		else if (Input.GetKeyDown ("joystick button 0") && pos2 == 5)
		{
			str [5] = "A";
			pos2++;
		}
		else if (Input.GetAxis("Vertical") > 0 && pos2 == 6)
		{
			str [6] = "U";
			pos2++;
		}
		else if (Input.GetAxis("Horizontal") > 0 && pos2 == 7)
		{
			str [7] = "R";
			pos2 = 0;
			pkmn = true;
		}
		
		if (Input.GetButtonDown("Fire1") && pkmn)
		{
			Application.LoadLevel("LevelPKMN");
		}
	} // end BULBASAUR()

} // end StartScript
