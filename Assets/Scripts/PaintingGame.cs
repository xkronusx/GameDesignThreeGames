using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingGame : MonoBehaviour
{
    public GameObject[] colorList;
    public int choice;
    public GameObject[] dontDelete;
    public int paintCurrScore = 0;
    public int paintHighScore;
    // Use this for initialization
    void Start()
    {
        paintHighScore = PlayerPrefs.GetInt("PaintHighScore");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {  //get left mouse button click
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //get a ray, originating at the mouse's position in the screen space mapped to the world space, and using the camera's projection geometry to project into the world space
            Debug.Log("Mouse position on mouse button press: " + Input.mousePosition);
            RaycastHit hit; //where the hit info will be stored

            if (Physics.Raycast(ray, out hit)) //note the use of keyword "out" here... stores the raycast hit info in "hit"
            {
                Debug.Log("hit: " + hit.point); //where did it hit?
                Vector3 myMousePos = new Vector3(hit.point.x, hit.point.y, 2);
                Instantiate(colorList[choice], new Vector3(hit.point.x, hit.point.y, 2), Quaternion.identity);
                Debug.DrawRay(ray.origin, ray.direction * 50f, Color.green, 60f); //go into scene view and see abstract art
            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 50f, Color.red, 60f); //go into scene view and see abstract art
            }
        }
        */
        if (paintCurrScore > paintHighScore)
        {
            paintHighScore = paintCurrScore;
            PlayerPrefs.SetInt("PaintHighScore", paintHighScore);
        }

    }
    /*void OnMouseDown()
    {
        Instantiate(colorList[choice]);

    }
    */
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Vector3 myMousePos = new Vector3(hit.point.x, hit.point.y, 2);
                //print("this is choice" + choice);
                //print(hit.collider.gameObject);
                if (hit.collider.gameObject != dontDelete[0] && hit.collider.gameObject != dontDelete[1] && hit.collider.gameObject != dontDelete[2] && hit.collider.gameObject != dontDelete[3] && hit.collider.gameObject != dontDelete[4])
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
    void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Vector3 myMousePos = new Vector3(hit.point.x, hit.point.y, 2);
            Instantiate(colorList[choice], new Vector3(hit.point.x, hit.point.y, 2), Quaternion.identity);
            paintCurrScore++;
        }
    }
}