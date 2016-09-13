using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {

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
		GameObject go = Instantiate(Resources.Load("Prefabs/Color")) as GameObject;

		int num = GetComponent<GetColor>().GetSpriteColor();

		go.GetComponent<SpriteRenderer>().sprite = sprites[num];
	}

}