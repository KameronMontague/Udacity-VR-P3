using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;
	public Transform coinCenter;

    public void OnCoinClick() {
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically

		Instantiate(coinPoofPrefab, coinCenter.position, Quaternion.Euler(new Vector3(-50, 0, 0)));

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
				}
			
		
	
}
