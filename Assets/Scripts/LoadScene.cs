﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void mainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void bubblePopperLoad()
    {
        SceneManager.LoadScene("BubblePopper");
    }
    public void paintingLoad()
    {
        SceneManager.LoadScene("Painting");
    }
    public void cubeNinjaLoad()
    {
        SceneManager.LoadScene("CubeNinja");
    }
    public void highScorePageLoad()
    {
        SceneManager.LoadScene("HighScores");
    }
}
