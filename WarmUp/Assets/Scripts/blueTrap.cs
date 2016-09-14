using UnityEngine;
using System.Collections;

public class blueTrap : MonoBehaviour {

	public AudioSource coin;
	public AudioSource bump;
	private int redBallCount; 
	private int blueBallCount;
	private int greenBallCount;
	private int yellowBallCount;
	public GameObject blueBall; 
	public GameObject ring; 

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

		if (other.gameObject.CompareTag ("BallBlue") && (ring.gameObject == null)) {

			Destroy (other.gameObject); 
			coin.Play (); 
			blueBallCount++; 
			blueBall.transform.localScale += Vector3.one;
			if (blueBallCount >= 10) {
				Destroy (blueBall); 

			}

			if (other.gameObject.CompareTag ("BallRed") && (ring.gameObject == null)) {

				Destroy (other.gameObject); 
				bump.Play (); 
				blueBallCount++; 
				if (redBallCount >= 1) {
					blueBallCount--;
				}

			}

			if (other.gameObject.CompareTag ("BallGreen") && (ring.gameObject == null)) {

				Destroy (other.gameObject); 
				bump.Play (); 
				greenBallCount++; 
				if (greenBallCount >= 1) {
					blueBallCount--;
				}

			}

			if (other.gameObject.CompareTag ("BallYellow") && (ring.gameObject == null)) {

				Destroy (other.gameObject); 
				bump.Play (); 
				yellowBallCount++; 
				if (yellowBallCount >= 1) {
					blueBallCount--;
				}

			}
		}

	}
}
