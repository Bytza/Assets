using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {			
			exit();
		}
	}
	void exit() {		
		//Application.LoadLevel ("_Prefata");
		SceneManager.LoadScene ("_Prefata");

	}
}
