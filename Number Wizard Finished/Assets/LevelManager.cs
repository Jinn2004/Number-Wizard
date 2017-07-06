using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string Levelname){
		Debug.Log ("Level load requested for " + Levelname);
		Application.LoadLevel (Levelname);
	}

	public void QuitLevel(string Levelname){
		Debug.Log ("We have called quit level" + Levelname);
		Application.Quit ();
	}

	public void Higher(string Levelname){
		Debug.Log ("We have said it is higher");
	}

	public void Lower(string Levelname){
		Debug.Log ("We have said that it is lower.");
	}
}
