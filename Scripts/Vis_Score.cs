using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vis_Score : MonoBehaviour {
	private Text scoreText;
	public  static int score;
	private bool scoreon;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		score = 0;
		scoreon = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (scoreon == true)
		{
			scoreon = false;
			score += 10;
		}
		else
		{
			scoreon = true;
		}
		scoreText.text = score.ToString();
	}
}
