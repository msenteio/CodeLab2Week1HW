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


		if (other.gameObject.CompareTag ("Ring")) {

			Destroy (other.gameObject); 
			coin.Play ();  
			}
}
}
