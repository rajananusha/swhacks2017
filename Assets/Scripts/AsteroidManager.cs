using UnityEngine;
using System.Collections;

public class AsteroidManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,30*Time.deltaTime*2,0);
	}
}
