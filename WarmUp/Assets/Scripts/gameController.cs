using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject blueRing;
	public GameObject redRing;
	public GameObject win; 

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		Win (); 
	}
	 
	void Win (){
		if ((blueRing.gameObject == null) & (redRing.gameObject == null)){ 
			win.SetActive(true); 
		}	
	
	}
}
