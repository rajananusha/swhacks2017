using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class AstroExplosionScript : MonoBehaviour {

    ParticleSystem ps;
    

	// Use this for initialization
	void Start () {

        ps = gameObject.GetComponent<ParticleSystem>();

        ps.Play();
		Destroy (gameObject, ps.duration);
		
	}
}
