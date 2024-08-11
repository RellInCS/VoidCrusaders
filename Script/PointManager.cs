using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public TMP_Text finalScore;
    public TMP_Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text = "Score " + score;
    }

    public void highScoreUpdate(){
        if (PlayerPrefs.HasKey("SavedHighScore")){
            if(score > PlayerPrefs.GetInt("SavedhighScore")){
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
            else {
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }
        finalScore.text = score.ToString();
        highScore.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
   
}
