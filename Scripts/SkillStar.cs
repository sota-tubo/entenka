using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillStar : MonoBehaviour {
	private Image star1, star2, star3, star4;
	private GameObject manager;
	private TempCal tempCal;
	private bool visStar, changeStar, change;

	// Use this for initialization
	void Start () {
		star1 = GetComponent<Image>();
		star2 = GameObject.Find("SkillStar2").GetComponent<Image>();
		star3 = GameObject.Find("SkillStar3").GetComponent<Image>();
		star4 = GameObject.Find("SkillStar4").GetComponent<Image>();

		manager = GameObject.Find("TempManager");
		tempCal = manager.GetComponent<TempCal>();
		visStar = true;
		changeStar = false;
		change = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (visStar == true && tempCal.skillon == false)
		{
			visStar = false;
			star1.enabled = false;
			star2.enabled = false;
			star3.enabled = false;
			star4.enabled = false;
		}
		else if (tempCal.skillon == true)
		{
			if (change == true)
			{
				StartCoroutine("Star");
			}
		}
	}
    
	private IEnumerator Star()
	{
		change = false;
		if (changeStar == false)
        {
            star1.enabled = true;
            star2.enabled = false;
            star3.enabled = true;
            star4.enabled = false;
        }
        else
        {
            star1.enabled = false;
            star2.enabled = true;
            star3.enabled = false;
            star4.enabled = true;
        }

		yield return new WaitForSeconds(0.5f);

		if (changeStar == false)
		{
			changeStar = true;
		}
		else
		{
			changeStar = false;
		}
		change = true;
	}
}
