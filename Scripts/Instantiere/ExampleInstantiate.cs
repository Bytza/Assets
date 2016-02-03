using UnityEngine;
using System.Collections;

public class ExampleInstantiate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 vec = new Vector3 (2,2,2);
		vec.x = 4;
		transform.position = vec;
		//transform.localScale = vec;
		//transform.Rotate (30, 30, 30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
