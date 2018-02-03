using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int max = 1001;
	int min = 1;
	int guess=500;

	void Start () {
		StartGame ();
		}
	void StartGame (){
		max = 1001;
		min = 1;
		guess = 500;
		print ("===================");

		print ("Welcome to Number Wizard ");
		print ("Select a number and don't tell me!");

		print ("Select a Number in less than :     " + (max-1));
		print ("Select a number in more than :     " + min);


		print ("Is your number more than or less than "+ guess);
		print ("up arrow = higher,down arrow = lower and return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
			}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}

	}

	void NextGuess(){
		guess = (min + max) / 2;
		print ("Higher or lower than " + guess);
		print ("up arrow = higher,down arrow = lower and return = equal");
	}
}
