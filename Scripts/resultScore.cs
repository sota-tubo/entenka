using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultScore : MonoBehaviour {
	public int result;

	private Text text;

	private void Awake()
	{
		result = Vis_Score.score;
	}

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		result += 5000;
		if (TempCal.bonus != 0)
		{
			result += TempCal.bonus * 10000;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		text.text = "スコア：" + result.ToString();
	}
}
