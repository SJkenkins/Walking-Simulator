using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animation hingehere;
    public GameObject this_key;
    public bool open;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OpenDoor()
    {
        if(this_key.activeSelf == true && open ==false)
        {
            open = true;
            hingehere.Play();
        }

        else if(this_key.activeSelf == false)
        {
            Debug.Log("ramasse la clef enculé");
        }
    }
}
