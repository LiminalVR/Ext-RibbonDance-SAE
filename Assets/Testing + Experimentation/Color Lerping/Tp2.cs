using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp2 : MonoBehaviour {

    public Color Confirm;
    private Renderer R;

    void Start()
    {
        R = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            R.enabled = false;
        }
    }
}
