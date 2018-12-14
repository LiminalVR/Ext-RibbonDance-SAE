using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {

    public GameObject MasterObject;
    public GameObject Victim;
    private Renderer R;
    public TriggerPrperites Change;
    public GameObject Hunter;

	// Use this for initialization
	void Start ()
    {
        R = Victim.GetComponent<Renderer>();
	}
	
    public void changecolor(Color cl)
    {
        Debug.Log(cl);
        R.material.color = cl;
    }
}
