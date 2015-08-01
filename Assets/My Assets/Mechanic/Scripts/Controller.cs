using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float acceleration = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void GoLeft() {
		transform.Translate (Vector2.left * Time.deltaTime * acceleration);
	}

	void GoRight() {
		transform.Translate (Vector2.right * Time.deltaTime * acceleration);
	}

	void GoUp() {
		transform.Translate (Vector2.up * Time.deltaTime * acceleration);
	}
}
