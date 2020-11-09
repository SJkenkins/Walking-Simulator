using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_Interact : MonoBehaviour
{

    public float range = 10f;
    public Camera fpsCam;


    // Start is called before the first frame update
    void Start()
    {
    //    layerInteraction = LayerMask.NameToLayer("Interactable");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.Shine();
            }
        }
        else
        {
            Target.StopShine();
        }

    }
}



//Mick Manc

/*

     Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, 100, ray.direction*rayLength, out hit))
        {
            Debug.Log(hit.transform.name);

            if (hit.transform.gameObject.layer == layerInteraction)
            {
                Debug.Log(hit.transform.name);  
                hit.transform.GetComponent<Interact>().InvokeEvent();

                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log(hit.transform.name);
                }
            }
        }
 */
