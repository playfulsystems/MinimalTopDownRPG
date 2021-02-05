using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
	public GameObject player;       // to set: drag the player game object to the inspector (while potion is selected)
	public Sprite newSprite;           // to set: drag the sprite from the project window to the inspector (while potion is selected)

	// Update is called once per frame
	void Update()
	{
		// checks to see if the player bounds intersects with the potion
		// here is the SpriteRenderer documentation:
		// https://docs.unity3d.com/ScriptReference/SpriteRenderer.html

		if (GetComponent<SpriteRenderer>().bounds.Intersects(player.GetComponent<SpriteRenderer>().bounds))
		{
			// change the sprite of the player by accessing its sprite controller
			player.GetComponent<SpriteRenderer>().sprite = newSprite;

			// destroys itself (since gameObject refers to the game object this script is attached to)
			Destroy(gameObject);
		}
	}
}
