using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text scoreText; 
	public Text operationText;
	public Move move;
	public TextMesh[] balls;
	public Text mistakeText;
	public GameObject gameOver;
	public Move eneble;
	public Text gameOverText;

	private int score;
	private int firstOperator;
	private int secondOperator;
	private int [] answers = new int[5];
	private string correctAnswer;
	private int mistakes = 0;


	void Start () {
		Reset ();
	}
	

	void Update () {
	
	}

	void Reset () {
		score = 0;
		scoreText.text = "0";
		CreateOperation ();
		mistakes = 0;
		mistakeText.text = "";


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
		if (mistakes < 5) {	
			if (correctAnswer == answer) {
				score = score + 5;
				scoreText.text = score.ToString ();
			} else {
				if (score < 2) {
					score = 0;
					MistakesCount();
				} else {
					score = score - 2;
					scoreText.text = score.ToString ();
					MistakesCount();
				}
			}
			CreateOperation ();
		}
		else {
			gameOverText.text = gameOverText.text + " " +
				"Score: " + score;
			gameOver.SetActive(true);
			eneble.enabled = false;
			Reset();
			operationText.text = " x ";
		}
	}

	void MistakesCount () {
		mistakes = mistakes + 1;
		mistakeText.text = mistakeText.text + "x";

	}
}
