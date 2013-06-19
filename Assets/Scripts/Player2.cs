using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// If the player presses the up button...
		if (Input.GetButton ("Up2"))
		{
			// ...move the player upward.
			transform.Translate (30 * Vector3.up * Time.deltaTime);
		}
		
		// If the player presses the down button...
		if (Input.GetButton ("Down2"))
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
	}
}
