using UnityEngine;
using System.Collections;

public class Showline : MonoBehaviour {

	public Show [] results;
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown (){
		foreach (Show res in results){
			res.ShowContent();
		}
	}
	void OnMouseUp (){
		foreach (Show res in results){
			res.HideContent();
		}
	}
}
