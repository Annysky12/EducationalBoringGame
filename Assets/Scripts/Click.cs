using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Click : MonoBehaviour {

	public GameManager gameManager;
	public Move father;
	void OnMouseDown (){
		//GetComponent<MeshRenderer> ().enabled = false;
		//transform.GetChild(0).GetComponent<MeshRenderer> ().enabled = false;
		transform.parent.transform.position = new Vector3 (0.0f, father.bottom, 0.0f);
		father.waiting = true;
		father.flip = 1;
		gameManager.AnswerClick (transform.GetChild(0).GetComponent<TextMesh> ().text);
	}
}
