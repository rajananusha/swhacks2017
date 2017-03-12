using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD

public class SwitchScene : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SceneChange());
        
    }


    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Main");
    }
}

=======
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
>>>>>>> origin/master
