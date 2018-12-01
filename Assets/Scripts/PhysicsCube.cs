using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCube : MonoBehaviour {
    public Vector3 rotator = new Vector3(30, 60, 90);
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if(rb.useGravity == true)
        {
            transform.Rotate(rotator * Time.deltaTime);
        }
        if (this.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
	}
    void FixedUpdate()
    {

    }

    /*void OnCollisionEnter(Collision col)
    {
        Rigidbody[] allRbs = this.GetComponentsInChildren<Rigidbody>();
        for (int r = 1; r < allRbs.Length; r++)
        {
            allRbs[r].isKinematic = false;
        }
    }*/
}
