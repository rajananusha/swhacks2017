using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

	//public GameObject AstroExplosion;
	GameObject enemy;
	int i;
	public static ArrayList enemyInfo = new ArrayList();

	void Start () {
		enemyInfo = new ArrayList();
		i = 1;

	}
	

	void Update () {
        
        Vector3 position = new Vector3 (Random.Range (-15, 15), Random.Range (-5, 5), Random.Range (10, 70));
        int c = Random.Range(1, 20);
            if (enemyInfo.Count < c) {
			if (enemyInfo.Count == 0) {

				enemy = Instantiate (Resources.Load ("Prefabs/Meteor"), position, Quaternion.identity) as GameObject;
				enemyInfo.Add((Object)enemy);
				enemy.name = "Meteor " + i.ToString();
				i++;
			} else {
				print (enemyInfo.Count);

				foreach (Object obj in enemyInfo) {
					Vector3 tempPosition = position - ((GameObject)obj).transform.position;	
					if (tempPosition.sqrMagnitude > 16f) {
						enemy = Instantiate (Resources.Load ("Prefabs/Meteor"), position, Quaternion.identity) as GameObject;
						enemy.name = "Meteor " + i.ToString();
						i++;
						enemyInfo.Add ((Object)enemy);
						break;
					}
					
				}
			}
		}
	}

    public void updateEnemy(Object target)
    {
        
		enemyInfo.Remove(target);

    }
	
}

