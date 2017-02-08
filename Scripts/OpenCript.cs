using UnityEngine;
using System.Collections;

public class OpenCript : MonoBehaviour {

	public Animation animateRight;
	public Animation animateLeft;


	public void OnCriptRightClick() {

		animateRight.Play ("CriptOpenRight");

	}

	public void OnCriptLeftClick() {

		animateLeft.Play ("CriptOpenLeft");

	}
}
