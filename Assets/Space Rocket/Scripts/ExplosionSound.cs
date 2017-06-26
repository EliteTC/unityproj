using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour {
	private float timer = 0.0f;
	float waitingTime = 1f;
	public AudioClip explosion = null;
	AudioSource expsource = null;
	void Start(){
		this.expsource = gameObject.AddComponent<AudioSource>();
		this.expsource.clip = explosion;
		expsource.Play ();
	}
	void Update(){
		timer += Time.deltaTime;
		if (timer > waitingTime) {
			timer = 0f;
			expsource.Play ();
		}

	}

}
