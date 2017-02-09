using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Transform keyCenter;
	public Animation keyAnimate;


	void Start()
	{

	}



	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located		
		// Make sure the poof animates vertically

		Instantiate (keyPoofPrefab, keyCenter.position, Quaternion.Euler (new Vector3 (-50, 0, 0)));

        // Call the Unlock() method on the Door
		Door.Unlock();
	
		//Bonus: Key Animation
		keyAnimate.Play ("KeyAnimation");

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject, .6f);

    }

}
