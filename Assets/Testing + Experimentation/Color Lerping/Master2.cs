using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master2 : MonoBehaviour
{
    public GameObject MasterObject;
    public GameObject Victim;
    private Renderer R;
    public Tp2 Change;
    public GameObject Hunter;

    public float speed = 1.0f;
    public Color CurrentColor;
    public Color NewColor;
    private float starttime;
    private float t;

    // Use this for initialization
    void Start()
    {
        R = Victim.GetComponent<Renderer>();
        CurrentColor = Victim.GetComponent<Renderer>().material.color;
        Debug.Log("Current Color = " + CurrentColor);
        starttime = Time.time;
    }
     void Update()
    {
        t = (Time.time - starttime) * speed;
        R.material.color = Color.Lerp(CurrentColor, NewColor, t);
        CurrentColor = NewColor;
        
    }

    public void changecolor(Color cl)
    {
        NewColor = cl;
        Update();
        Debug.Log("New Color = " + CurrentColor);
    }
}
