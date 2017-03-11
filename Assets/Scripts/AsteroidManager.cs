using UnityEngine;
using System.Collections;

public class AsteroidManager : MonoBehaviour {

	int x,y,z;

	// Use this for initialization
	void Start () {
		x = Random.Range (-30, 30);
		y = Random.Range (-30, 30);
		z = Random.Range (-30, 30);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x*Time.deltaTime*2,y*Time.deltaTime*2,z*Time.deltaTime*2);
	}
}
