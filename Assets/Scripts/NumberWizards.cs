using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess=500;

	void Start () {
		
		print ("Welcome to Number Wizard ");
		print ("Select a number and don't tell me!");



		print ("Select a Number in less than :     " + max);
		print ("Select a number in more than :     " + min);
		max += 1;
		print ("Is your number more than or less than "+ guess);
		print ("up arrow = higher,down arrow = lower and return = equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (min + max) / 2;
			print ("Higher or lower than " + guess);

		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = (min + max) / 2;
			print ("Higher or lower than " + guess);
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
		}

	}
}
