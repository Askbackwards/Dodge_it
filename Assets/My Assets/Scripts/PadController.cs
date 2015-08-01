using UnityEngine;
using System.Collections;

public class PadController : MonoBehaviour {

	public bool isLeft, isRight, isUp;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			for(int i = 0; i <= Input.touchCount; i++) {
				Touch touch = Input.GetTouch (i);
				Vector2 touchPos = touch.position;
				Vector2 thisPos = transform.position;
				if(touchPos == thisPos) {
					if (isLeft == true) {
						SendMessage("GoLeft");
					}
					else if (isRight == true) {
						SendMessage("GoRight");
					}
					else if (isUp == true) {
						SendMessage("GoUp");
					}
				}
			}
		}
	}
}
