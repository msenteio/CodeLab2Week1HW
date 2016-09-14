using UnityEngine;
using System.Collections;

public class BallSpawnTwo : MonoBehaviour {

	public Sprite[] sprites;
	public float time = .3f; 

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", time, 1);
	}

	// Update is called once per frame
	void Update () {

	}

	void Spawn(){
		GameObject go = Instantiate(Resources.Load("Prefabs/Color"), new Vector3(25.2f, 0f, 0f), Quaternion.identity) as GameObject;
		int num = GetComponent<GetColor>().GetSpriteColor();

		go.GetComponent<SpriteRenderer>().sprite = sprites[num];

		if(num == 0) {
			go.tag = "BallBlue";
		}
		if(num == 1) {
			go.tag = "BallGreen";
		}
		if(num == 2) {
			go.tag = "BallRed";
		}
		if(num == 3) {
			go.tag = "BallYellow";
		}
		//go.GetComponent<SpriteRenderer>().sprite = sprites[num];
	}

}