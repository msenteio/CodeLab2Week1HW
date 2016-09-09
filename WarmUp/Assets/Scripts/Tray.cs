using UnityEngine;
using System.Collections;

public class Tray : MonoBehaviour {

	public float Y_Min = -100f; //Set this to the lowest Y value you want the Item to move to.
	public float Y_Max = 100f; //Set this to the highest Y value you want the Item to move to.
	public float VerticalSpeed = 5f; //Speed the Item will move vertically.
	public float Dir = 1f; //Direction the Item is moving, either up or down.

	void Start() {

		Dir = Random.value > 0.5f ? 1f : -1f; //Set Dir to start randomly either Up or Down.
		float Start = Random.Range(50, 80);//Get a random value between Min and Max to start off at.

		transform.position = new Vector3(transform.position.x, Start, transform.position.z);//Set item's Vertical position to a random value between Max and Min.
	}

	void Update () {

		//Check to see if the Item's Y position is above Max or below Min and switch direction.
		if (transform.position.y > Y_Max)
			Dir = -1f;
		else if (transform.position.y < Y_Min)
			Dir = 1f;

		//Compute new position based on VerticalSpeed and whether we are going up or down
		Vector3 NewPos = new Vector3(transform.position.x, transform.position.y + ((VerticalSpeed * Time.deltaTime) * Dir), transform.position.z);
		transform.position = NewPos;
	}
}
