using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 0.5f;
	public float top = 5.0f;
	public float bottom;
	public bool waiting = false;
	public float waitingTime = 0.0f;
	private float curret_Time;
	public int flip = 1;
	//public Rigidbody baloon;
	// Use this for initialization
	void Start () {
		bottom = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (!waiting) {
			Vector3 direction = Vector3.up * speed * Time.deltaTime * flip;
			transform.position += direction;
			if (transform.position.y >= top) {
				waiting = true;
				flip = -1;
			}
			if (transform.position.y <= bottom) {
				waiting = true;
				flip = 1;
			}
			//transform.position += direction;
		} else {
			curret_Time += Time.deltaTime;
			if (curret_Time >= waitingTime){
				waiting = false;
				curret_Time = 0.0f;
			}

		}

	}


}
