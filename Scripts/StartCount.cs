using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCount : MonoBehaviour {
	private Text countDown;

	[RuntimeInitializeOnLoadMethod]
	private void Init()
	{
		countDown = GetComponent<Text>();
		StartCoroutine("Down");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	private IEnumerator Down()
	{
		countDown.text = "3";

		yield return new WaitForSeconds(1.0f);

		countDown.text = "2";

		yield return new WaitForSeconds(1.0f);

		countDown.text = "1";

		yield return new WaitForSeconds(1.0f);

		countDown.text = "スタート！";

		yield return new WaitForSeconds(0.5f);

		countDown.enabled = false;
		Time.timeScale = 1.0f;
	}
}
