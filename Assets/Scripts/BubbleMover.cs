using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMover : MonoBehaviour {
    public float timeTillMove = 0;
    private bool movedBubble;
    private Rigidbody rb;
    private int randomInt;
    private float speedOfBubble = 1000f;
    // Use this for initialization
    Camera myCamera;
	void Start () {
        myCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        /*if(timeTillMove > 30 && timeTillMove < 32)
        {
            rb = this.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 10, 0);
        }
        */
    }

    private void OnMouseDown()
    {
        myCamera.GetComponent<BubbleSpawner>().currScore++;
        myCamera.GetComponent<BubbleSpawner>().currentBubbles--;
        Destroy(this.gameObject);
    }
    void FixedUpdate(){
        timeTillMove += Time.deltaTime;
        if (timeTillMove > 5 && movedBubble == false)
        {
            this.transform.position = new Vector3(Random.Range(-12, 12), Random.Range(-7, 11), 0);
            randomInt = Random.Range(1, 4);
            switch (randomInt)
            {
                case 1:
                    this.GetComponent<Rigidbody>().AddForce( 1 * speedOfBubble, 1 * speedOfBubble, 0);
                    break;

                case 2:
                    this.GetComponent<Rigidbody>().AddForce( -1 * speedOfBubble, 1 * speedOfBubble, 0);
                    break;
                case 3:
                    this.GetComponent<Rigidbody>().AddForce(-1 * speedOfBubble, -1 * speedOfBubble, 0);
                    break;
                case 4:
                    this.GetComponent<Rigidbody>().AddForce( 1 * speedOfBubble, -1 * speedOfBubble, 0);
                    break;
            }
            movedBubble = true;
        }
        if (timeTillMove > 15) {
            myCamera.GetComponent<BubbleSpawner>().bubblesMissed++;
            myCamera.GetComponent<BubbleSpawner>().currentBubbles--;
            Destroy(this.gameObject);
        }
    }
}