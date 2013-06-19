using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{
	// Keep track of the player's score.
	public int Player1Score { get; set; }
	public int Player2Score { get; set; }
	
	// Use this for initialization
	void Start ()
	{
		// Intiliaze the scores to zero.
		Player1Score = 0;
		Player2Score = 0;
	}
}
