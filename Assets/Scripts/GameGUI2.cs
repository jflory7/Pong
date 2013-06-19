using UnityEngine;
using System.Collections;

public class GameGUI2 : MonoBehaviour
{
	// GUI Text score containers.
	public GUIText playerScore;
	
	// The game state.
	private GameState state;
	
	// Use this for initialization
	void Start ()
	{
		// Find and store the state script.
		state = (GameState)FindObjectOfType (typeof(GameState));
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
		// update the score display with the values from the game state.
		playerScore.text = "" + state.Player2Score;
	}
}