using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	//public float speed = 2;
	public float upForce = 175;					
	private bool isDead = false;			
	public GameObject explosion;
	public float time = 0f;
	private Rigidbody2D rb2d;				

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		//rb2d.velocity = Vector2.right * speed;
	}

	void Update()
	{
			if (Time.time - time >= 15) {
				time = Time.time;
				if(upForce >=50)
					upForce -= 5;
			}

		if (isDead == false) 
		{
			
			if (Input.GetKeyDown(KeyCode.Space)) 
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(Vector2.up * upForce);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		rb2d.velocity = Vector2.zero;
		isDead = true;
		//explosion = (GameObject) Instantiate();
		GetComponent<SpriteRenderer>().enabled = false;
		Instantiate(explosion, this.transform.position, Quaternion.identity);
		GameControl.instance.HeroDied ();

	}
}
