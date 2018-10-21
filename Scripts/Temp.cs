using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour {
	public int numtag = 0;
	public Image GrassImage, OasisImage, SabakuImage;

	private Text tempText;
	private GameObject manager;
	private TempCal tempCal;

	// Use this for initialization
	void Start () {
		tempText = GetComponent<Text>();
		manager = GameObject.Find("TempManager");
		tempCal = manager.GetComponent<TempCal>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (tempCal.temperature[numtag - 1] < 20f)
		{
			tempCal.temperature[numtag - 1] = 20f;
		}

        //気温に合わせて文字サイズと文字の色変更し、画像も切り替える
		if (tempCal.temperature[numtag - 1] >= 20f && tempCal.temperature[numtag - 1] < 30f)
		{
			GrassImage.enabled = true;
			OasisImage.enabled = false;
			SabakuImage.enabled = false;

			tempText.fontSize = 35;
			Color textColor = new Color(255f, 255f, 255f);
			tempText.color = textColor;
		}
		else if (tempCal.temperature[numtag - 1] >= 30f && tempCal.temperature[numtag - 1] < 40f)
		{
			GrassImage.enabled = true;
			OasisImage.enabled = false;
            SabakuImage.enabled = false;

			tempText.fontSize = 40;
			Color textColor = new Color(255f, 255f, 255f);
            tempText.color = textColor;
		}
		else if (tempCal.temperature[numtag - 1] >= 40f && tempCal.temperature[numtag - 1] < 50f)
		{
			GrassImage.enabled = false;
            OasisImage.enabled = true;
            SabakuImage.enabled = false;

			tempText.fontSize = 45;
			Color textColor = new Color(255f, 190f, 0f);
            tempText.color = textColor;
		}
		else if (tempCal.temperature[numtag - 1] >= 50f)
		{
			GrassImage.enabled = false;
            OasisImage.enabled = false;
            SabakuImage.enabled = true;

			tempText.fontSize = 55;
			Color textColor = new Color(255f, 0f, 0f);
            tempText.color = textColor;
		}

		tempText.text = ((int)tempCal.temperature[numtag - 1]).ToString() + "℃";
	}
}
