using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text timeText;
	public Text startText;
	public Text scoreText;
	public GameObject endPanel;
	public static int score = 0;
	private float time = 60f;
	public static bool isStart = false;
	
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			isStart = true;
			ResumeGame();
			startText.gameObject.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    void FixedUpdate()
    {
		if (time > 0)
        {
            time -= Time.fixedDeltaTime;
            timeText.text = "Time : " + Mathf.RoundToInt(time).ToString();
        }
        else
        {
			endPanel.SetActive(true);
			scoreText.text = "Score : " + score.ToString();
			PauseGame();
		}
	}
	
	void PauseGame ()
    {
        Time.timeScale = 0;
    }

	void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}
