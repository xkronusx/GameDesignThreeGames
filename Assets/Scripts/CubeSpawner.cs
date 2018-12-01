using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
    public GameObject[] cubes;
    public int i;
	// Use this for initialization
	void Start () {
        //InvokeRepeating("SpawnCube", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void SpawnCube()
    {
        i = Random.Range(0, cubes.Length);
        //print(i);
        GameObject currCube = Instantiate(cubes[i], this.transform.position, Quaternion.identity);
        currCube.GetComponent<Rigidbody>().AddForce(this.transform.rotation.x * 1000, this.transform.rotation.y * 1000, 0);
    }
    void FixedUpdate()
    {
        /*i++;
        if (i == 100)
        {
            GameObject currCube = Instantiate(cubes[0], this.transform.position, Quaternion.identity);
            currCube.GetComponent<Rigidbody>().AddForce(this.transform.rotation.x * 1000, this.transform.rotation.y * 1000, 0);
            i = 0;
        }
        */
    }
}
