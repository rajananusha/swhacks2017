using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AsteroidManager : MonoBehaviour {
	//public GameObject AstroExplosion;
	int x,y,z;
    EnemyManager e;
    bool flag;
    // Use this for initialization
    void Start () {
        x = Random.Range (-30, 30);
		y = Random.Range (-30, 30);
		z = Random.Range (-30, 30);
        flag = true;
	}

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            float speed = 0.01f * (GameObject.Find("Managers").GetComponent<ScoreManager>().score + 1);
            Vector3 tempPosition = new Vector3(-0.1378743f, -0.100489f, 0.2082129f) - transform.position;
            if (tempPosition.sqrMagnitude < 1f)
            {
                flag = false;

				//GameObject.Find ("Managers").GetComponent<ScoreManager>.WriteScore ();
				SceneManager.LoadScene("Finish");
				//StartCoroutine (EndGame);
                
            }

            transform.position = Vector3.Lerp(transform.position, new Vector3(-0.1378743f, -0.100489f, 0.2082129f), Time.deltaTime * speed);
            transform.Rotate(x * Time.deltaTime * 2, y * Time.deltaTime * 2, z * Time.deltaTime * 2);
        }
    }

	/*IEnumerator EndGame() {
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene("Finish");
	}*/
}
