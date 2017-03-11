using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {


	GameObject enemy;
	int i;

	// Use this for initialization
	void Start () {
		i = 1;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-10, 10));

		if (GameObject.FindGameObjectsWithTag ("Enemy").Length < 10) {

			enemy = Instantiate (Resources.Load("Prefabs/Asteroid"), position, Quaternion.identity) as GameObject;
			enemy.name = "Asteroid " + i.ToString();
			i++;
		}
	
	}
}
