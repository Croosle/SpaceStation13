using UnityEngine;
using System.Collections;

public class Mainscript : MonoBehaviour {

	public Transform rightDoor;

	bool openorclose = false;

	void Start() {
		animation["right"].AddMixingTransform(rightDoor);
		animation["rightclose"].AddMixingTransform(rightDoor);
	}

	public void Open () {
		if (openorclose == false) {
			animation.Play ("left");
			animation.Blend ("right");
			openorclose = true;
		} else {
			animation.Play("leftclose");
			animation.Blend("rightclose");
			openorclose = false;
		}
	}
}