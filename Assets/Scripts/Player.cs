using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	// Holds the player's previous position.
	private Vector3 lastPosition;
	
	// Holds the velocity at which the player is moving.
	public Vector3 Velocity { get; set; }
	
	// Use this for initialization
	void Start ()
	{
		// Initialize the player's position.
		lastPosition = transform.position;
		
		// Initialize the player's velocity.
		Velocity = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		// If the player presses the up button...
		if (Input.GetButton ("Up"))
		{
			// ...move the player upward.
			transform.Translate (30 * Vector3.up * Time.deltaTime);
		}
		
		// If the player presses the down button...
		if (Input.GetButton ("Down"))
		{
			// ...move the player downward.
			transform.Translate (30 * Vector3.down * Time.deltaTime);
		}
		
		// If the player's paddle is above the screen...
		if (transform.position.y > 14)
		{
			// ...reset the player's paddle to the top of the screen.
			transform.position = new Vector3 (transform.position.x, 14, transform.position.z);
		}
		
		// If the player's paddle is below the screen...
		if (transform.position.y < -14)
		{
			// ...reset the player's paddle to the bottom of the screen.
			transform.position = new Vector3 (transform.position.x, -14, transform.position.z);
		}
		// Store the player's velocity.
		Velocity = (transform.position - lastPosition) / Time.deltaTime;
		
		// Store the player's previous position.
		lastPosition = transform.position;
	}
}
