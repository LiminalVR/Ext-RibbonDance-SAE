using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float XAngularSpeed;
    public float YAngularSpeed;
    public float ZAngularSpeed;

    void Update ()
    {
        transform.Rotate(XAngularSpeed, YAngularSpeed,ZAngularSpeed);
	}
}
