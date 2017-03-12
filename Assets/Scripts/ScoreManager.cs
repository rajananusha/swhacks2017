using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ScoreManager : MonoBehaviour {
	public int score;
	string fileName = "score.txt";
	StreamWriter scoreFile;
	// Use this for initialization

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WriteScore() {
	
		if (!File.Exists (fileName)) {
			scoreFile = File.CreateText (fileName);
		}

		scoreFile.WriteLine ("Player 1#" + score.ToString ());
	
	}
}
