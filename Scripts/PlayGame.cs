using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {
	private AudioSource audioSource;
	private Text CountDownText;
	private Button StartButton;
	private Image StartImage;
	private Text StartText;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		CountDownText = GameObject.Find("CountDown").GetComponent<Text>();
		StartButton = GameObject.Find("StartButton").GetComponent<Button>();
		StartImage = GameObject.Find("StartButton").GetComponent<Image>();

		var childTransform = GameObject.Find("StartButton").transform;

		foreach (Transform child in childTransform.transform)
		{
			StartText = child.gameObject.GetComponent<Text>();
		}

		CountDownText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked()
	{
		audioSource.Play();

		StartButton.enabled = false;
		StartImage.enabled = false;
		StartText.enabled = false;

		StartCoroutine("Click");
	}

	IEnumerator Click()
	{
		CountDownText.enabled = true;
		CountDownText.text = "3";

		yield return new WaitForSeconds(1.0f);

		CountDownText.text = "2";

		yield return new WaitForSeconds(1.0f);

		CountDownText.text = "1";

		yield return new WaitForSeconds(1.0f);

		SceneManager.LoadScene("Main");
	}
}
