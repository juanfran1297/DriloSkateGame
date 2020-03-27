using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionMaxima : MonoBehaviour
{
    public Text highScore;
    public Text score;

    //private void Awake()
    //{
    //    PlayerPrefs.DeleteKey("Points");
    //}
    //// Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        score.text = PlayerPrefs.GetInt("Points", 0).ToString();
    }

    private void Update()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        score.text = PlayerPrefs.GetInt("Points").ToString();
    }

    public void ResetPoints()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
