using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter2 : MonoBehaviour {

    public Master2 MasterGameobject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Orb")
        {
            //Debug.Log(other.GetComponent<TriggerPrperites>().Confirm);
            MasterGameobject.changecolor(other.GetComponent<Tp2>().Confirm);
        }
    }

}
