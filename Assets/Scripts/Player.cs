using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Camera camera1;
	private float nextTime = 0.0F;
	private float timeRate = 1F;
	RaycastHit hit;
	public Mainscript Opendoor;
	

	// Update is called once per frame
	void Update () {
		Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (Input.GetKeyDown (KeyCode.F) && Time.time > nextTime && hit.collider.gameObject.tag == "Finish") {
				nextTime = Time.time + timeRate;
				Opendoor = GameObject.FindObjectOfType(typeof(Mainscript)) as Mainscript;
				Opendoor.Open();
			}
		}
	}
}
