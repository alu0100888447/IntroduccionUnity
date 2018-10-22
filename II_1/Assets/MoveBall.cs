using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

    private Rigidbody rb;
    public int randomMoveLengthMultiplier = 3;
    //private System.Random randomNumberGenerator;
    //private const int GENERATOR_SEED = 0;
    //private const int MIN_FORCE_COMPONENT = -1;
    //private const int MAX_FORCE_COMPONENT = 1;

    void Start () {
        rb = GetComponent<Rigidbody>();
        //randomNumberGenerator = new System.Random(GENERATOR_SEED);
    }
	
	void FixedUpdate () {
        //rb.AddForce(GenerateRandomForce());
        rb.AddForce(Random.insideUnitSphere * randomMoveLengthMultiplier);
    }

    //Vector3 GenerateRandomForce() {
    //    int x = randomNumberGenerator.Next(MIN_FORCE_COMPONENT, MAX_FORCE_COMPONENT);
    //    int z = randomNumberGenerator.Next(MIN_FORCE_COMPONENT, MAX_FORCE_COMPONENT);

    //    return new Vector3(x, 0, z);
    //}
}
