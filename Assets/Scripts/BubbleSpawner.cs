using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleSpawner : MonoBehaviour {
    public GameObject[] bubbleList;
    public int i;
    public int maxBubbles = 10;
    public int currentBubbles = 0;
    public float spawnTimer = 0;
    public float diffTimer = 5;
    public int currScore = 0;
    public int bubblesMissed = 0;
    public int highScore;
    public Text topText;
    public GameObject gameEnd;
    // Use this for initialization
    void Start () {
        highScore = PlayerPrefs.GetInt("highscore");
        topText.text = "Score: " + currScore + " " + "     Bubbles missed: " + bubblesMissed + "     Highscore: " + highScore ;
    }
	
	// Update is called once per frame
	void Update () {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > diffTimer)
        {
            if (currentBubbles < maxBubbles)
            {
                i = Random.Range(1, bubbleList.Length);
                Instantiate(bubbleList[i]);
                currentBubbles++;
            }
            spawnTimer = 0;
        }
        if(bubblesMissed > 9)
        {
            if (currScore > PlayerPrefs.GetInt("highscore")){
                PlayerPrefs.SetInt("highscore", currScore);
                highScore = currScore;
                
            }
            gameEnd.SetActive(true);
        }
        if (currScore > highScore) {
            PlayerPrefs.SetInt("highscore", currScore);
            highScore = currScore;
        }
        topText.text = "Score: " + currScore + " " + "     Bubbles missed: " + bubblesMissed + "     Highscore: " + highScore ;
        if (diffTimer > 0) {
            diffTimer -= 0.0001f;
        }
    }
}
