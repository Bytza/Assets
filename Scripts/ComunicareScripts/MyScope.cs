using UnityEngine;
using System.Collections;

public class MyScope : MonoBehaviour {

	OtherScope other;
	public float otherScale;

	// Use this for initialization
	void Start () {
		other = (OtherScope)GameObject.FindObjectOfType (typeof(OtherScope));
		//print (other.name);

	}
	
	// Update is called once per frame
	void Update () {
		other.Size = otherScale;
	}
}
