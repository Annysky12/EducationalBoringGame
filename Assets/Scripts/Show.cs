using UnityEngine;
using System.Collections;

public class Show : MonoBehaviour {

	public string content;
	public TextMesh contenText;

	void OnMouseDown ()
	{
		ShowContent ();
	}

	void OnMouseUp ()
	{
		HideContent (); 
	}

	void Start () {
		contenText.text = content;
	}

	public void ShowContent (){
		transform.GetChild(0).GetComponent<MeshRenderer> ().enabled = true;
	}

	public void HideContent (){
		transform.GetChild(0).GetComponent<MeshRenderer> ().enabled = false;
	}
	void Update () {
	}
}
