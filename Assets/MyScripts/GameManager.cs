using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	
	public bool gameOver;
	public GameObject gameOverPanel;
	public bool wonGame;
	public GameObject wonGamePanel;
	
    void OnTriggerEnter2D(Collider2D target)
	{
		if (target.CompareTag("Coin"))
		{
			Won();
			Destroy (target.gameObject);
			Debug.Log ("Tresure");
		}
	}

	
	void Won()
	{
		wonGame = true;
		wonGamePanel.SetActive (true);
		
		return;
	}
	
	void GameOver()
	{
		gameOver = true;
		gameOverPanel.SetActive (true);
		
		return;
	}
	
	public void PlayAgain()
	{
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}
	
	public void Quit()
	{
		SceneManager.LoadScene("MenuScene");
	}
}
