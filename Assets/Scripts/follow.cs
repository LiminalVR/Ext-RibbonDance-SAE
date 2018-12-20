using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour
{
    // The target marker.
    public GameObject target;
    public float standby = 10.0f;

    // Speed in units per sec.
    public float speed;

    void Start()
    {
         
    }
    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        standby -= Time.deltaTime;
        //Debug.Log(standby);
        if(standby <= 0)
        {
         //Debug.Log("Incoming");
         // Move our position a step closer to the target.
        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            
        }   
    }
}