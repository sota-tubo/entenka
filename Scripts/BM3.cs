using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BM3 : MonoBehaviour {
	public Image rain;

	private GameObject manager;
    private TempCal tempCal;
	private AudioSource audioSource;
	private bool now;

    // Use this for initialization
    void Start()
    {
		audioSource = GetComponent<AudioSource>();
		now = false;
		manager = GameObject.Find("TempManager");
        tempCal = manager.GetComponent<TempCal>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (now == true)
        {
			rain.enabled = true;
			tempCal.temperature[2] -= 0.2f;
        }
		else
		{
			rain.enabled = false;
		}
    }

	public void OnClicked()
	{
		
	}

    public void OnTD()
    {
		audioSource.Play();
        now = true;
    }

    public void OnTU()
    {
        now = false;
    }
}
