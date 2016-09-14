using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

	public AudioSource coin; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		//int num = GetComponent<GetColor>().GetSpriteColor();

		//GetComponent<SpriteRenderer>().sprite = sprites[num];

		if (other.gameObject.CompareTag ("Ring")) {

			Destroy (other.gameObject); 
			//other.gameObject.SetActive (false);
			//score += 1;
			//scoreText = "Score: " + score;
			coin.Play ();  
			}
}
}
