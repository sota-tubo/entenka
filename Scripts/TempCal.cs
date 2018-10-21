using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempCal : MonoBehaviour {
	public float[] temperature = new float[3];
	public bool skillon;
	public static int bonus;

	private float tempinc;
	private GameObject time;
	private TimeText timeText;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 3; i++)
		{
			temperature[i] = Random.Range(20f, 30f);
		}
		skillon = true;
		bonus = 0;
		time = GameObject.Find("Time");
		timeText = time.GetComponent<TimeText>();
		tempinc = 0.03f;
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		for (int i = 0; i < 3; i++)
        {
			temperature[i] += tempinc;

			if (temperature[i] >= 50f)
			{
				SceneManager.LoadScene("GameOver");
			}
        }

		if (timeText.timeCount <= 1.0f)
		{
			int bonusnum = 0;
			for (int i = 0; i < 3; i++)
			{
				if (temperature[i] < 40f)
				{
					bonusnum++;
				}
			}
			bonus = bonusnum;
		}

	}

	public void inc1 ()
	{
		tempinc = 0.05f;
	}

	public void inc2 ()
	{
		tempinc = 0.07f;
	}

	public void Skill ()
	{
		audioSource.Play();
		skillon = false;
		for (int i = 0; i < 3; i++)
		{
			float dectemp = Random.Range(10f, 15f);
			temperature[i] -= dectemp;
		}
	}
}
