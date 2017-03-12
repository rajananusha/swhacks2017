using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Leap;
using UnityEngine.UI ;

public class Laser : MonoBehaviour
{
	Text scoreLabel ;
	public LineRenderer line;
	public GameObject target;
	public float t;
	AudioSource audio;
	//int score ;
	//ParticleSystem ps;
	//bool flag;


	// Use this for initialization
	void Start()
	{
		
		scoreLabel = GameObject.Find ("Score Text").GetComponent<Text> ();
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
		line.useWorldSpace = false;
		line.SetVertexCount (2);
//		line.material = new Material (Shader.Find ("Particles/Additive"));
//		line.SetColors(Color.yellow, Color.yellow);
//		line.material.color = Color.yellow;
		line.SetWidth(0.25f, 0.25f);
		t = 0.0f;
		audio = GameObject.Find ("Managers").GetComponent<AudioSource> ();

	}


	// Update is called once per frame
	void Update()
	{
		//score = GameObject.Find ("Managers").GetComponent<ScoreManager> ().score;

		if (line.enabled) {
			t += 0.5f * Time.deltaTime;
		}
		RaycastHit hit;

		Controller controller = new Controller ();
		Frame frame = controller.Frame(); // controller is a Controller object
		if(frame.Hands.Count > 0){
			List<Hand> hands = frame.Hands;
            Hand hand;
            int extendedFingers = 0;
            foreach (Hand h in hands)
            {
                if (h.IsRight)
                {
                    hand = h;
                    for (int f = 0; f < hand.Fingers.Count; f++)
                    {
                        Finger digit = hand.Fingers[f];
                        if (digit.IsExtended)
                            extendedFingers++;
                    }
                }
            }

            if (extendedFingers == 5) {
				line.enabled = true;
				Vector3 rayDirection = transform.TransformDirection(Vector3.down);
				if (Physics.Raycast (transform.position, rayDirection, out hit)) {
					if (hit.collider) {
						t = 0f;
						target = hit.transform.gameObject;
						line.SetPosition (1, new Vector3 (0,-hit.distance,0 ));

						if (target.tag == "Enemy") {
							//ps = target.GetComponent<ParticleSystem>();
							//ps.Play();
							audio.Play ();
							Destroy (target/*, ps.duration*/);
                            EnemyManager e = new EnemyManager();
                            e.updateEnemy((Object)target);
							GameObject.Find ("Managers").GetComponent<ScoreManager> ().score++;

							scoreLabel.text = "SCORE : " + GameObject.Find ("Managers").GetComponent<ScoreManager> ().score.ToString();
							
						}
					}
				} else {
					t = 0f;
					line.SetPosition (1, new Vector3 (0,-5000000,0));
				}
			} else {
				line.enabled = false;
			}
		}
	}
}
