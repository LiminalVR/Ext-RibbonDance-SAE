using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPrperites : MonoBehaviour
{
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

