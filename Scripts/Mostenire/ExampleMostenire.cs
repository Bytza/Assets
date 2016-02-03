using UnityEngine;
using System.Collections;

public class ExampleMostenire : MonoBehaviour {

	public GameObject ChildObject;

	// Use this for initialization
	void Start () {
		PianoCat famousCat = new PianoCat ();
		famousCat.PlayPiano ();
		famousCat.Meow ();
		print (famousCat.Paws);
		GameObject[] gos = GameObject.FindObjectsOfType (typeof(GameObject)) as GameObject[];
		foreach (GameObject go in gos) {
			print (go);
			Component comp = go.GetComponent (typeof(Parent));
			if(comp != null){
				ChildObject = go; 
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public class Cat{
		public int Paws = 4;
		public void Meow(){
			print ("meow");
		}
	}
	public class PianoCat : Cat{
		public void PlayPiano(){
			Meow ();
		}
	}
}
