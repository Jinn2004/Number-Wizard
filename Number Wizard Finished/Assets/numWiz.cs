using UnityEngine;
using System.Collections;
using UnityEngine.UI;
	
public class numWiz : MonoBehaviour {
	
	// Declare a variable that will be for the max value
	int numberMax;
	
	// Declare a variable that will be for the min value
	int numberMin;
	int ComputerGuess;
	int guess;
	// So I can change the number on the screen.
	public Text text;

	// Use this for initialization
	void Start() {
		StartGame ();
	}

	void StartGame () {
		numberMax = 10000;
		numberMin = 0;
		guess = Random.Range (3000, 7000);
		ComputerGuess = 0;
		text.text = guess.ToString();
		// use crtl + ' for info on any type of thing.
	}

	void NextGuess() {
		ComputerGuess++;
		if (ComputerGuess >= 10) 
		{
			Application.LoadLevel ("Win");
		}
		else
		{
			// Computer guesses again
			guess = Random.Range (numberMin, numberMax + 1);
			//guess = (numberMax + numberMin) / 2;
			text.text = guess.ToString();
		}
	}

	public void GuessLower(){
		numberMax = guess;
		NextGuess ();
	}

	public void GuessHigher(){
		numberMin = guess;
		NextGuess();
	}

	public void Correct(){
		// When the computer wins
		Application.LoadLevel ("Lose");
	}



}
