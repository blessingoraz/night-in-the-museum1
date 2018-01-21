using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

	public GameObject player;
	private AudioSource source;
	private GameObject introSource;
	private bool startPlaying = false;
	// Use this for initialization
	void Start () {
		source = transform.GetComponent<AudioSource> ();
		introSource = GameObject.Find("Intro Audio Source");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		Vector3 toOther = player.transform.position - transform.position;
		float position = Mathf.Abs (Vector3.Dot (forward, toOther));
		if (position <= 10 && startPlaying == false) {
			StopIntroSource ();
			source.Play ();
			startPlaying = true;
		}

		if (position > 10 && source.isPlaying){
			source.Stop ();
		}

	}

	void StopIntroSource() {
		if (introSource) {
			AudioSource source = introSource.GetComponent<AudioSource> ();
			if (source.isPlaying) {
				source.Stop ();
			}
		}
	}
}
