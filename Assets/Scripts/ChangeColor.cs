using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public GameObject colorChoice;
    public GameObject paintPlane;
	// Use this for initialization
	void Start () {
        paintPlane = GameObject.Find("PaintPlane");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        //print(colorChoice.name);
        if(colorChoice.name == "BlackSphere") {
           paintPlane.GetComponent<PaintingGame>().choice = 0;
            //print("BlackSphere");
        }
        if (colorChoice.name == "BlueSphere")
        {
            paintPlane.GetComponent<PaintingGame>().choice = 1;
            //print("BlueSphere");
        }
        if (colorChoice.name == "RedSphere")
        {
            paintPlane.GetComponent<PaintingGame>().choice = 2;
            //print("RedSphere");
        }
        if (colorChoice.name == "GreenSphere")
        {
            paintPlane.GetComponent<PaintingGame>().choice = 3;
            //print("GreenSphere");
        }
    }
}
