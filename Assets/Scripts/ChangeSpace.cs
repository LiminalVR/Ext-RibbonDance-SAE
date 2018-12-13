using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpace : MonoBehaviour {

    //public GameObject orbs;
    private Renderer R;
    public float revive;
    public float settime = 5f;
    //public Material Sky1;

    //Skybox material
    //public int tintX;
    //public int tintY;
    //public int tintZ;
    public Color Tintset;
    //public int floorX;
    //public int floorY;
    //public int floorZ;
    public Color Groundset;
    public float Expo;

    void Start()
    {
        R = GetComponent<Renderer>();
        revive = settime;
    }
    void Update()
    {
        revive -= Time.deltaTime;
        //Debug.Log(revive);
        if (revive <= 0)
        {
            Revive();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wisp")
        {
            R.enabled = false;
            if(RenderSettings.skybox.HasProperty("_SkyTint"))
            {
                RenderSettings.skybox.SetColor("_SkyTint", Tintset);
                Debug.Log(RenderSettings.skybox.GetColor("_SkyTint"));
            }
            if(RenderSettings.skybox.HasProperty("_GroundColor"))
            {
                RenderSettings.skybox.SetColor("_GroundColor", Groundset);
            }
            if(RenderSettings.skybox.HasProperty("_Exposure"))
            {
                RenderSettings.skybox.SetFloat("_Exposure", Expo);
            }
            Update(); 
        }

    }
    void Revive()
    {
        R.enabled = true;
        revive = settime;
    }
    
      
    


}
  