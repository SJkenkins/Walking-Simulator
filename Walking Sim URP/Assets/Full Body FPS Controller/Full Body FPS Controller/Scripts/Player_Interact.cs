using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_Interact : MonoBehaviour
{

    public float rayLength = 10;
    public int layerInteraction;


    // Start is called before the first frame update
    void Start()
    {
        layerInteraction = LayerMask.NameToLayer("Interactable");
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
