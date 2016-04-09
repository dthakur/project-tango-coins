using UnityEngine;
using System.Collections;

public class OnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DoTouch() {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Destroy(this);
	}
}
