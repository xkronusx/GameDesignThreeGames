using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeNinjaGame : MonoBehaviour {
    public GameObject[] Spawners;
    private int i;
    public int cubeCurrScore = 0;
    public int cubeHighScore;
    public Text ScoreText;
    // Use this for initialization
    void Start () {
        foreach (GameObject spawner in Spawners) {
            Instantiate(spawner);
        }
        cubeHighScore = PlayerPrefs.GetInt("cubeHighscore");
        ScoreText.text = "Score: " + cubeCurrScore + " " + "     Highscore: " + cubeHighScore;
        InvokeRepeating("callSpawn", 1f, 3f);
    }
    void callSpawn()
    {
        i = Random.Range(0, Spawners.Length);
        //print(i);
        Spawners[i].GetComponent<CubeSpawner>().SpawnCube();
    }
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = "Score: " + cubeCurrScore + " " + "     Highscore: " + cubeHighScore;
        if(cubeCurrScore > cubeHighScore)
        {
            cubeHighScore = cubeCurrScore;
            PlayerPrefs.SetInt("cubeHighscore", cubeHighScore);
        }
    }

    void FixedUpdate()
    {
        //SpawnCube //InvokeRepeating("SpawnCube", 1f, 1f);
        
    }
}
