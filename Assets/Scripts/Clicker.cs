using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {

	GameObject camera;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
	}
	
	// Update is called once per frame
	void Update () {
		var dist = Mathf.Abs(Vector3.Distance(
			this.transform.position, 
			camera.transform.position));

		Debug.Log(dist);
		if (dist < 1) {
			var audio = GetComponent<AudioSource>();
			audio.Play();

			GetComponent<Renderer>().enabled = false;
			Destroy(this);
//			Application.Quit();
		}
	}
}
