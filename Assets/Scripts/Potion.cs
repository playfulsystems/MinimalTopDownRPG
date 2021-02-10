using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
	public GameObject player;   // to set: drag the player game object to the inspector
	public Sprite oldMan;	// to set: drag the sprite from the project window to the inspector

	void Update()
	{
		if (GetComponent<SpriteRenderer>().bounds.Intersects(player.GetComponent<SpriteRenderer>().bounds))
		{
			// change the sprite of the player by accessing its sprite controller
			player.GetComponent<SpriteRenderer>().sprite = oldMan;
		}
	}
}
