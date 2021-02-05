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
		// here is the SpriteRenderer documentation:
		// https://docs.unity3d.com/ScriptReference/SpriteRenderer.html


		if (character.GetComponent<SpriteRenderer>().bounds.Intersects(player.GetComponent<SpriteRenderer>().bounds))
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
}
