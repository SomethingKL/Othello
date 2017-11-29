using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDriver : MonoBehaviour {
	public GameObject board;
	public GameObject piece;

	private BoardController boardController;
	private GameObject[,] pieces = new GameObject[8,8];

	// Use this for initialization
	void Start () {
		boardController = board.GetComponent<BoardController> ();
	}

	// function for adding piece to game
	//   takes a coordinate and a color
	private void addPiece(char x, int y, bool black){
		Vector3 location = getLocation (x, y);
		// initiate piece with above Vector3
		// set color
	}

	// helper function:
	//   returns a Vector3 for a coordinate
	private Vector3 getLocation(char x, int y){
		Vector3 answer = Vector3.zero;
		switch (x) {
			case 'A':
				answer += new Vector3 (0, 0, -3.85f);
				break;
			case 'B':
				answer += new Vector3 (0, 0, -2.75f);
				break;
			case 'C':
				answer += new Vector3 (0, 0, -1.65f);
				break;
			case 'D':
				answer += new Vector3 (0, 0, -0.55f);
				break;
			case 'E':
				answer += new Vector3 (0, 0, 0.55f);
				break;
			case 'F':
				answer += new Vector3 (0, 0, 1.65f);
				break;
			case 'G':
				answer += new Vector3 (0, 0, 2.75f);
				break;
			case 'H':
				answer += new Vector3 (0, 0, 3.85f);
				break;
			default:
				break;
		}
		switch (y) {
			case 1:
				answer += new Vector3 (-3.85f, 0, 0);
				break;
			case 2:
				answer += new Vector3 (-2.75f, 0, 0);
				break;
			case 3:
				answer += new Vector3 (-1.65f, 0, 0);
				break;
			case 4:
				answer += new Vector3 (-0.55f, 0, 0);
				break;
			case 5:
				answer += new Vector3 (0.55f, 0, 0);
				break;
			case 6:
				answer += new Vector3 (1.65f, 0, 0);
				break;
			case 7:
				answer += new Vector3 (2.75f, 0, 0);
				break;
			case 8:
				answer += new Vector3 (3.85f, 0, 0);
				break;
			default:
				break;
		}
		return answer;
	}
	
	// Update is called once per frame
	void Update () {
		// find which square the mouse is currently over
	}

	// helper function:
	//   determines if coordinate is relevant

	// function to highlight move result

	// helper function:
	//   adds ghost piece

	// function to highlight all possible moves
}