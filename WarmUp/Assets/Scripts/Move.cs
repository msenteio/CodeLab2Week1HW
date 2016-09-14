using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	//Inspector Variables

	private Rigidbody2D rigidbody;
	public SpriteRenderer renderer; 
	public GameObject player; 
	public AudioSource coin; 
	public int score;
	public GUIText scoreText; 
	public Sprite[] sprites;

	public float playerSpeed = 50; //speed player moves

	void Start () {


		rigidbody = GetComponent<Rigidbody2D>();
		renderer = GetComponent<SpriteRenderer>();


	}

	void Update() 
	{

		MoveForward(); // Player Movement 
	}

	void MoveForward()
	{

		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		 if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
	
		}
		if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
		}
		 if (Input.GetKey ("right")) {//Press up arrow key to move forward on the Y AXIS
			transform.Translate (playerSpeed * Time.deltaTime, 0, 0);
 
		} 

	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		//int num = GetComponent<GetColor>().GetSpriteColor();

		//GetComponent<SpriteRenderer>().sprite = sprites[num];

		if (other.gameObject.CompareTag ("Ball")) {

			Destroy (other.gameObject); 
			//other.gameObject.SetActive (false);
			//score += 1;
			//scoreText = "Score: " + score;
			coin.Play (); 
			renderer.color = new Color (0f, 0f, 0f, 1f);
			//gameObject.GetComponent<Renderer>().color = new Color (0.5f, 0.5f, 0.5f, 1f);

		} else {
			renderer.color = new Color(255f, 166f, 245f, 255f);

		}
	}




}
