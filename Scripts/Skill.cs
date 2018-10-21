using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {
	public Image skillImage;
	public Button skillButton;
	public Text skillText;

	private GameObject manager;
	private TempCal tempCal;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("TempManager");
		tempCal = manager.GetComponent<TempCal>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked()
	{
		skillImage.enabled = false;
		skillText.enabled = false;
		skillButton.enabled = false;
		tempCal.Skill();
	}
}
