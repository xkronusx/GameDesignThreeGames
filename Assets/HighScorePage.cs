using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorePage : MonoBehaviour {
    private int bubblePopperHighScorePage;
    private int paintingHighscorePage;
    private int cubeHighScorePage;
    public Text bPopperText;
    public Text paintingText;
    public Text cubeNinjaText;

    // Use this for initialization
    void Start () {

        bubblePopperHighScorePage = PlayerPrefs.GetInt("highscore");
        bPopperText.text = "Bubble Popper Highscore: " + bubblePopperHighScorePage;
        paintingHighscorePage = PlayerPrefs.GetInt("PaintHighScore");
        paintingText.text = "Painting Highscore: " + paintingHighscorePage;
        cubeHighScorePage = PlayerPrefs.GetInt("cubeHighscore");
        cubeNinjaText.text = "Cube Ninja Highscore: " + cubeHighScorePage;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
