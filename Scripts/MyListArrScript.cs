using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyListArrScript : MonoBehaviour {

	public List<string> myList;

	public List<string> literaList;

	public List<string> testList;

	// Use this for initialization
	void Start () {
		myList = new List<string> ();
		myList.Add ("Aici avem");
		myList.Add ("un nou");
		myList.Add ("element");

		print ("numarul de liste = "+myList.Count);
		print ("primul element este "+myList[1]);

		string myString = "";
		foreach (string newString in myList) {
			myString += newString + " ";
		}

		print (myString);


		literaList = new List<string> ();
		literaList.Add ("A");
		literaList.Add ("B");
		literaList.Add ("C");
		literaList.Add ("D");
		literaList.Add ("E");
		literaList.Add ("F");

		literaList.Remove ("C");
		literaList.Insert (2, "B.5");
		literaList.Clear ();

		string myLitera = "";
		foreach (string newLitera in literaList) {
			myLitera += newLitera + " ";
		}
		print (myLitera);


		print ("in test List exista " + testList.Count);

		string myTestList = "";
		foreach (string newTestList in testList){
			myTestList += newTestList + " ";
		}
		print (myTestList);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
