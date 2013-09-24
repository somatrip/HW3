using UnityEngine;
using System.Collections;

public class flagraise : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}	
		void OnTriggerEnter() {
			
		transform.Translate (0,4f,0) ;

	}
	
}
