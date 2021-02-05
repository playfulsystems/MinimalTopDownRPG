using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		// checks if the user presses the left arrow and subtracts from current x position if so
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			// to set a Vector2, you must create a new Vector2 set with two values
			transform.position = new Vector2(transform.position.x - 0.025f, transform.position.y);
		}

		// checks if the user presses the right arrow and adds to current x position if so
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = new Vector2(transform.position.x + 0.025f, transform.position.y);
		}

		// checks if the user presses the up arrow and adds to current y position if so
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector2(transform.position.x, transform.position.y + 0.025f);
		}

		// checks if the user presses the down arrow and subtracts from current y position if so
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector2(transform.position.x, transform.position.y - 0.025f);
		}

	}
}
