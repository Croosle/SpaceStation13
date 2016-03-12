using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Camera camera1;
	RaycastHit hit;
	public GameObject door;
	

	// Update is called once per frame
	void Update () {
		Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.gameObject.tag == "Finish" && Input.GetKeyUp(KeyCode.F)) {
				door = hit.collider.gameObject;
				if (door.GetComponent<Animator>().GetBool("IsOpen?") == false) {
					door.GetComponent<Animator>().SetBool ("IsOpen?", true);
				} else {
					door.GetComponent<Animator>().SetBool ("IsOpen?", false);
				}
			}
		}
	}
}
