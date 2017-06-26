using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour 
{
	
	private BoxCollider2D deathZoneCollider;		
	private float deathZoneLength;		


	private void Awake ()
	{
			deathZoneCollider = GetComponent<BoxCollider2D> ();
		    deathZoneLength = deathZoneCollider.size.x;
	}

	//Update runs once per frame
	private void Update()
	{
		if (transform.position.x < -deathZoneLength)
		{
			RepositionBackground ();
		}
	}


	private void RepositionBackground()
	{
		Vector2 offSet = new Vector2(deathZoneLength * 2f, 0);
		transform.position = (Vector2) transform.position + offSet;
	}
}