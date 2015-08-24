using UnityEngine;
using System.Collections;

public class Mainscript : MonoBehaviour {

	public Transform rightDoor;

	bool openorclose = false;

	void Start() {
		GetComponent<Animation>()["right"].AddMixingTransform(rightDoor);
		GetComponent<Animation>()["rightclose"].AddMixingTransform(rightDoor);
	}

	public void Open () {
		if (openorclose == false) {
			GetComponent<Animation>().Play ("left");
			GetComponent<Animation>().Blend ("right");
			openorclose = true;
		} else {
			GetComponent<Animation>().Play("leftclose");
			GetComponent<Animation>().Blend("rightclose");
			openorclose = false;
		}
	}
}