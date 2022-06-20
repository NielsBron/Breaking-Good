using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RvTrigger : MonoBehaviour
{
    public Transform teleportDestination;
    public Transform teleportDestination2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "inRV")
        {
            transform.position=teleportDestination.position;
            transform.rotation=teleportDestination.rotation;
        }
        if (collider.gameObject.tag == "outRV")
        {
            transform.position=teleportDestination2.position;
            transform.rotation=teleportDestination2.rotation;
        }
    }
}
