using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealDialog : MonoBehaviour
{
	public GameObject player;		// to set: drag the player gameobject to the inspector (while a dialogobject is selected)
	public GameObject character;    // to set: drag the character gameobject to the inspector (while a dialogobject is selected)
	public GameObject dialog;       // to set: drag the text gameobject to the inspector (while a dialogobject is selected)

	// Update is called once per frame
	void Update()
	{
		// checks to see if the player bounds intersects with the other character
		if (SpriteOverlap(character, player))
		{
			// passing true to SetActive on a gameobject makes it visible
			dialog.SetActive(true);
		}
		else
		{
			// passing false to SetActive on a gameobject makes it invisible
			dialog.SetActive(false);
		}
	}

	bool SpriteOverlap(GameObject go1, GameObject go2)
	{
		Bounds b1 = go1.GetComponent<SpriteRenderer>().bounds;
		Bounds b2 = go2.GetComponent<SpriteRenderer>().bounds;
		return b1.Intersects(b2);
	}
}
