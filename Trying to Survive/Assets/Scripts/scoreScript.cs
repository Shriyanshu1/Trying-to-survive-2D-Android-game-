using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreScript : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public Text finalScore;
    public Text newHiscore;
    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        finalScore.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore"))
        {

            PlayerPrefs.SetInt("HighScore", score);
            newHiscore.gameObject.SetActive(true);
        }
        else if(score < PlayerPrefs.GetInt("HighScore"))
        {
            newHiscore.gameObject.SetActive(false);
        }
    }
    public void startScorecount()
    {
        StartCoroutine(scoreCount());
    }
    IEnumerator scoreCount()
    {
        yield return new WaitForSeconds(3);
        score++;
        StartCoroutine(scoreCount());
    }
    
}
