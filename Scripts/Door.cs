using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	public static bool locked = true;

	//public static bool isKeyCollected = false;
	public Animation animate;

	public AudioClip mySound;
	public AudioClip mySound2;
	public AudioSource mySource;
	//public Key unlock;




	//public AnimationClip animationClip; //Assign from Editor

	void Start() {
		
		animate = GetComponent<Animation> ();



	}
	public static void Unlock()
	{
		// You'll need to set "locked" to false here
		locked = false;
	}


    public void OnDoorClick() {
        // If the door is unlocked and it is not fully raised
		if (locked == true) 
		{
			//print ("Door is locked");
			mySource.clip = mySound2;
			mySource.Play ();


		}
            // Animate the door raising up
		else if(locked == false)
		{
			mySource.clip = mySound;
			mySource.Play ();
			animate.Play ("DoorOpen");
		}
    }


}
