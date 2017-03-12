using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad > 5f)
        {
           
            SceneManager.LoadScene("Main"); 
        }
	}
}
