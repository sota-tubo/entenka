using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeText : MonoBehaviour {
	private Text timetext;
	public float timeCount;
	private bool Inc1, Inc2;
	private GameObject manage;
	public TempCal tempCal;

	// Use this for initialization
	void Start () {
		timeCount = 60f;
		timetext = GetComponent<Text>();
		Inc1 = true;
		Inc2 = true;
		manage = GameObject.Find("TempManager");
		tempCal = manage.GetComponent<TempCal>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeCount -= Time.deltaTime/ (float)1.5f;
        
		if (timeCount <= 30f && Inc1 == true)
		{
			Inc1 = false;
			tempCal.inc1();
		}
		else if (timeCount <= 10f && Inc2 == true)
        {
            Inc2 = false;
            tempCal.inc2();
        }

		if (timeCount <= 0f)
		{
			SceneManager.LoadScene("GameClear");
		}

		timetext.text = "残り時間：" + ((int)(timeCount)).ToString();
	}
}
