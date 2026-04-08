using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
    }
}
