using UnityEngine;
using System.Collections;

public class Mainscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionExit(Collision collisionInfo) {
		print("No longer in contact with " + collisionInfo.transform.name);
	}
}
