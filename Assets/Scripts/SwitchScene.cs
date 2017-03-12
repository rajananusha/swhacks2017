using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

