using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MethPickup : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionText;
    public GameObject Meth;
    public AudioSource PickupSound;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver ()
    {
        if (TheDistance <= 1) 
        {
            ActionText.SetActive(true);
        }
        if (TheDistance >= 1) {
            ActionText.SetActive(false);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 1) 
            {
                Meth.SetActive(false);
                ActionText.SetActive(false);
                PickupSound.Play();
            }
        }   
        
    }

    void OnMouseExit()
    {
        ActionText.SetActive(false);
    }
}
