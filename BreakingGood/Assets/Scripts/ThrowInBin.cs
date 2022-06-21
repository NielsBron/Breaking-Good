using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowInBin : MonoBehaviour
{
    public float TheDistance;
    public GameObject Bin;
    public GameObject ActionText;
    public AudioSource TrashBinSound;

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
                Bin.GetComponent<Animation>().Play("binanimation");
                ActionText.SetActive(false);
                TrashBinSound.Play();
            }
        }   
        
    }

    void OnMouseExit()
    {
        ActionText.SetActive(false);
    }
}
