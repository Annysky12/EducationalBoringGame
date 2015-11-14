using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text scoreText; 
	public Text operationText;
	public Move move;
	public TextMesh[] balls;

	private int score;
	private int firstOperator;
	private int secondOperator;
	private int [] answers = new int[5];
	private string correctAnswer;

	void Start () {
		Reset ();
	}
	

	void Update () {
	
	}

	void Reset () {
		score = 0;
		scoreText.text = "0";
		CreateOperation ();

	}

	void CreateOperation(){
		ArrayList indexArray = new ArrayList ();
		ArrayList selectedIndex = new ArrayList ();
		firstOperator = (int)(1 + Random.value * 9);
		secondOperator = (int)(1 + Random.value * 9);
		for (int i = 0; i < 5; i++) {
			indexArray.Add (i);
		}
		for (int i = 0; i < 5; i++) {
			int selected = (int)(Random.value * (indexArray.Count - 1));
			selectedIndex.Add (indexArray[selected]);
			indexArray.RemoveAt(selected);
		}
		answers [0] = firstOperator * secondOperator;
		answers [1] = firstOperator + secondOperator;
		answers [2] = (firstOperator * 10) + secondOperator;
		answers [3] = (int)(1 + Random.value * 99);
		answers [4] = (int)(1 + Random.value * 99);
		correctAnswer = answers [0].ToString ();

		for (int i = 0; i < 5; i++) {
			balls [i].text = answers [(int)selectedIndex[i]].ToString();
		}

		operationText.text = firstOperator.ToString() + " X " + secondOperator.ToString();

	}

	public void AnswerClick (string answer){
		if (correctAnswer == answer) {
			score = score + 5;
			scoreText.text = score.ToString();
		}
		CreateOperation ();
	}
}
