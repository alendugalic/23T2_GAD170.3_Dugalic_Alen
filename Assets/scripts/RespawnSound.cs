using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSound : MonoBehaviour
{
    public AudioSource haHa;
    

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag =="Hazard")
        {
            haHa.Play();
        }
    }

}
