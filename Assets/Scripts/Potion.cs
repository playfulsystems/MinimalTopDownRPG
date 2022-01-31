using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
	public GameObject player;   // to set: drag the player game object to the inspector
	public Sprite oldMan;	// to set: drag the sprite from the project window to the inspector

	void Update()
	{
		if (SpriteOverlap(gameObject, player))
		{
			// change the sprite of the player by accessing its sprite controller
			player.GetComponent<SpriteRenderer>().sprite = oldMan;
		}
	}

	bool SpriteOverlap(GameObject go1, GameObject go2)
	{
		Bounds b1 = go1.GetComponent<SpriteRenderer>().bounds;
		Bounds b2 = go2.GetComponent<SpriteRenderer>().bounds;
		return b1.Intersects(b2);
	}
}
