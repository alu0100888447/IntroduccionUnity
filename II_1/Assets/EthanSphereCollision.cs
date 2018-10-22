using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanSphereCollision : MonoBehaviour {

    public int numberOfCollisionsWithSpheres = 0;
	
    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            numberOfCollisionsWithSpheres += 1;
            Debug.Log("We hit a sphere");
        }
    }
}
