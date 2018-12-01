using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTail : MonoBehaviour {
    public GameObject cubePiece = null;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}

    Ray GenerateMouseRay(Vector3 touchPos)
    {
        Vector3 mousePosFar = new Vector3(touchPos.x,touchPos.y, Camera.main.farClipPlane);
        Vector3 mousePosNear = new Vector3(touchPos.x,touchPos.y, Camera.main.nearClipPlane);
        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Plane myPlane = new Plane(Camera.main.transform.forward, this.transform.position);
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (myPlane.Raycast(mRay, out rayDistance))
            {
                this.transform.position = mRay.GetPoint(rayDistance);
            }

            Ray mouseRay = GenerateMouseRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
            {
                cubePiece = hit.transform.gameObject;
                Rigidbody[] allRbs = cubePiece.transform.parent.gameObject.GetComponentsInChildren<Rigidbody>();
                allRbs[0].useGravity = false;
                for (int r = 1; r < allRbs.Length; r++)
                {
                    allRbs[r].isKinematic = false;
                    allRbs[r].useGravity = true;
                    allRbs[r].AddExplosionForce(100, this.transform.position, 3.0f);
                }
                //rb = cubePiece.GetComponent<Rigidbody>();
                //rb.AddForce(1000, 1000, 0);
                Camera.main.GetComponent<CubeNinjaGame>().cubeCurrScore += 5;
                if(cubePiece.transform.parent.name == "CubeObjectGreen(Clone)")
                {
                    Camera.main.GetComponent<CubeNinjaGame>().cubeCurrScore += 5;
                }
                Destroy(cubePiece);
            }
        }

    }
    void FixedUpdate()
    {
       /* if (Input.GetMouseButton(0))
        {
            Plane myPlane = new Plane(Camera.main.transform.forward, this.transform.position);
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (myPlane.Raycast(mRay, out rayDistance))
            {
                this.transform.position = mRay.GetPoint(rayDistance);
            }

            Ray mouseRay = GenerateMouseRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
            {
                cubePiece = hit.transform.gameObject;
                Rigidbody[] allRbs = cubePiece.transform.parent.gameObject.GetComponentsInChildren<Rigidbody>();
                allRbs[0].useGravity = false;
                for (int r = 1; r < allRbs.Length; r++)
                {
                    allRbs[r].isKinematic = false;
                    allRbs[r].useGravity = true;
                    allRbs[r].AddExplosionForce(100, this.transform.position, 3.0f);
                }
                //rb = cubePiece.GetComponent<Rigidbody>();
                //rb.AddForce(1000, 1000, 0);
                Camera.main.GetComponent<CubeNinjaGame>().cubeCurrScore += 5;
                Destroy(cubePiece);
            }
        }
        */
    }
}
