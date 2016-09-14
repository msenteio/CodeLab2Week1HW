using UnityEngine;
using System.Collections;

public class redTrap : MonoBehaviour {

	public AudioSource coin;
	public AudioSource bump;
	private int redBallCount; 
	private int blueBallCount;
	private int greenBallCount;
	private int yellowBallCount;
	public GameObject redBall; 
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

		if (other.gameObject.CompareTag ("BallRed") && (ring.gameObject == null)) {

			Destroy (other.gameObject); 
			//other.gameObject.SetActive (false);
			//score += 1;
			//scoreText = "Score: " + score;
			coin.Play (); 
			redBall.transform.localScale += Vector3.one;
			redBallCount++; 
			if (redBallCount >= 10) {
				Destroy (redBall); 
			}

			if (other.gameObject.CompareTag ("BallBlue") && (ring.gameObject == null)) {

				//Destroy (other.gameObject); 
				other.gameObject.SetActive (false);
				//score += 1;
				//scoreText = "Score: " + score;
				bump.Play (); 
				blueBallCount++; 
				if (blueBallCount >= 1) {
					redBallCount--;
				}

		}


			if (other.gameObject.CompareTag ("BallGreen") && (ring.gameObject == null)) {

				Destroy (other.gameObject); 
				bump.Play (); 
				greenBallCount++; 
				if (greenBallCount >= 1) {
					redBallCount--;
				}

			}

			if (other.gameObject.CompareTag ("BallYellow") && (ring.gameObject == null)) {

				Destroy (other.gameObject); 
				bump.Play (); 
				yellowBallCount++; 
				if (yellowBallCount >= 1) {
					redBallCount--;
				}

			}
}

}
}
