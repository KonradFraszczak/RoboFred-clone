using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	Image timerBar;
	public float maxTime = 5f;
	float timeLeft;
	public GameObject gameOverPanel;
	
    void Start()
    {
        timerBar = GetComponent<Image> ();
		timeLeft = maxTime;
    }

    public void Update()
    {
        if (timeLeft > 0)
		{
			timeLeft -= Time.deltaTime;
			timerBar.fillAmount = timeLeft / maxTime;
		}
		else {
			gameOverPanel.SetActive (true);
			Time.timeScale = 0;
		}
    }
}
