using UnityEngine;
using System.Collections;

public class ExampleStatic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool Akey = Input.GetKeyDown (KeyCode.A);
		if (Akey) {
			print ("Tasta A");
		}
	}
}
