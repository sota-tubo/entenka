using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overresult : MonoBehaviour {
	public int resultscore;

	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		resultscore = Vis_Score.score;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		text.text = "スコア：" + resultscore.ToString();
	}
}
