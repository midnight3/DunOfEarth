using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameHandler : MonoBehaviour {

	public GameObject floorPrefab;
	public GameObject wallPrefab;
	public GameObject playerPrefab;
	public GameObject parentTerrain;

	// Use this for initialization
	void Start () {
		for (float i = 0f; i < 10f; i++) {
			for (float j = 0f; j < 10f; j++) {
				Instantiate (floorPrefab, new Vector3 (i, j), Quaternion.identity, parentTerrain.transform);
			}
		}
		Instantiate (playerPrefab, new Vector3 (5.0f, 5.0f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
