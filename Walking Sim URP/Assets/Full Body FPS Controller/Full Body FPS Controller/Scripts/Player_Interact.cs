using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_Interact : MonoBehaviour
{

    public float range = 10f;
    public Camera fpsCam;

    GameObject Cible;

    Target target;


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
            Cible = hit.transform.gameObject;
            if (Cible.tag=="Collectibles" )
            {
                target = hit.transform.GetComponent<Target>();
                target.Shine();
            }
            else if (target!=null && Cible.tag!="Collectibles" && target.shine==true)
            {
                target.StopShine();
         
            }
            
        }
    }
}
