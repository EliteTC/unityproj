using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
	public static GameControl instance;			
	public Text scoreText;						
	public GameObject gameOvertext;				
	public Text bestScoreText;
	private int score = 0;						
	public bool gameOver = false;				
	public float scrollSpeed = -1.5f;

	int bestscore;

	void Awake()
	{
		//PlayerPrefs.SetInt("bestscore", 10);
		bestscore = PlayerPrefs.GetInt("bestscore");
	//	print (bestscore);
		bestScoreText.text = "Best score: " + bestscore.ToString ();

		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Update()
	{
		if (gameOver && Input.GetMouseButtonDown(0)) 
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void addScore()
	{
		if (gameOver)	
			return;
		score++;
		scoreText.text = "Score: " + score.ToString();
	}

	public void HeroDied()
	{
		if (score > bestscore) {
			PlayerPrefs.SetInt("bestscore", score);
			PlayerPrefs.Save();
		}
		gameOvertext.SetActive (true);
	    gameOver = true;
	}
}
