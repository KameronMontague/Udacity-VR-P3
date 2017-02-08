using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	//public bool keyCollected;
	public Transform keyCenter;
	//public Door unlockDoor;
	//public GameObject doorState;

	void Start()
	{
		//doorState = GameObject.FindGameObjectWithTag ("TempleDoor");

		//unlockDoor = doorState.GetComponent<Door> ();
	}

	void Update()
	{
		//Bonus: Key Animation


	}

	public void OnKeyClicked()
	{
		// Instatiate the KeyPoof Prefab where this key is located		
		// Make sure the poof animates vertically
	
		Instantiate (keyPoofPrefab, keyCenter.position, Quaternion.Euler (new Vector3 (-50, 0, 0)));


        // Call the Unlock() method on the Door
		Door.Unlock();
		//unlockDoor.locked = false;

		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);

    }

}
