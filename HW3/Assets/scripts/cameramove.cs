using UnityEngine;
using System.Collections;

public class cameramove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	if ( Time.time > 0f && Time.time < 1.5f) {
			
		transform.position += new Vector3( 0f, -3f , 0f) * Time.deltaTime ;
			
		}	
			
		if ( Time.time > 2f && Time.time < 6f) {	
				
		transform.position += new Vector3( 0f, 0f , 1.2f) * Time.deltaTime ;		
		
		}	
		
		if ( Time.time > 6f && Time.time < 25f) {	
				
		transform.position += new Vector3( 0f, 0f , 2f) * Time.deltaTime ;		
		
		}	
		
		if ( Time.time > 25f && Time.time < 30f) {	
				
		transform.position += new Vector3( 0f, 0f , 3.5f) * Time.deltaTime ;		
		
		}	
		
	}
}
