using UnityEngine;
using System.Collections;

public class MyArrayScript : MonoBehaviour {

	public string[] myArray;

	// Use this for initialization
	void Start () {


		print ("lungimea lui este de " + myArray.Length);
		print ("al doile element este " + myArray[1]);

		string str = " ";
		foreach(string tempString in myArray){
			str += tempString + " | ";
		}
		print (str);
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
