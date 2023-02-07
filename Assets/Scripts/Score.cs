using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score instance;

    public TextMeshProUGUI scoreText;

    int score = 0;

    private void Awake()
    {
        instance= this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score += 10;
        scoreText.text = score.ToString();

        if(score == 100) {
            Time.timeScale = 0f;
            SceneManager.LoadScene("End");
        }
    }
}
