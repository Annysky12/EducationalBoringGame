using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Click : MonoBehaviour {

	//private GameObject father;
	public Move father;
	void OnMouseDown (){
		//GetComponent<MeshRenderer> ().enabled = false;
		//transform.GetChild(0).GetComponent<MeshRenderer> ().enabled = false;
		transform.parent.transform.position = new Vector3 (0.0f, -1.5f, 0.0f);
		father.waiting = true;

	}
}
