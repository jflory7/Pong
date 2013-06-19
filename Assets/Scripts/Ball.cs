using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	// A script to hold information about the state of the game.
	public GameState gameState;
	
	// Use this for initialization
	void Start ()
	{
		// Add an initial force to the ball.
		rigidbody.AddForce (800, -800, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (gameState.Player1Score);
		Debug.Log (gameState.Player2Score);
		
		// If the enemy has scored...
		if (transform.position.x<-23)
		{
			// ...update the enemy's score.
			gameState.Player2Score++;
			
			// ...reset the ball.
			ResetBall ();
		}
		// If the other enemy has scored...
		if (transform.position.x>23)
		{
			// ...update the enemy's score.
			gameState.Player1Score++;
			
			// ...reset the ball.
			ResetBall ();
		}
	}

	// Reset the ball if a point is scored.
	private void ResetBall ()
	{
		// Reset the ball's position to zero.
		transform.position = new Vector3 (0, 14, 0);
		
		// Reset the ball's velocity.
		rigidbody.velocity = new Vector3 (0, 0, 0);
		
		// Reapply the velocity's force.
		rigidbody.AddForce (800, -800, 0);
	}

	// Is fired when a collision occurs.
	void OnCollisionEnter (Collision collision)
	{
		// Check to see if the ball has collided with the player.
		Player player = collision.gameObject.GetComponent<Player>();
		
		// Check to see if player exists...
		if (player !=null)
		{
			// ...if so, add force to the ball in the direction that the player's paddle is moving.
			rigidbody.AddForce (0, player.Velocity.y * 20, 0);
		}
	}
}
