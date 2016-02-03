using UnityEngine;
using System.Collections;

public class Looping : MonoBehaviour {

	public int numCubes = 10;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < numCubes; i++){
			for(int j = 0; j < numCubes; j++){
				for(int a = 0; a < numCubes; a++){
					GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
					box.transform.position = new Vector3 (i * 2.0f,j * 2.0f,a * 2.0f);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
