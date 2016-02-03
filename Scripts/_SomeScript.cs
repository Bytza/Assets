using UnityEngine;
using System.Collections;

public class _SomeScript : MonoBehaviour {


	public GameObject A_Cube;
	public GameObject B_Cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color col = Color.red;
		float Ax = A_Cube.transform.position.x;
		float Bx = B_Cube.transform.position.x;

		if (Ax > Bx) {
			//col = Color.black;
			float d = Ax + Bx;
			if (d < 3f) {
				col = Color.green;
			} else if (d >= 5.0f && d < 8f) {
				col = Color.yellow;

			} else if (d >= 8f && d < 10f) {
				col = Color.cyan;
			} else {
				col = Color.black;
			}

		}else if(Ax <= Bx){
			col = Color.blue;
		}

		GetComponent<Renderer>().material.color = col;
	}
}
