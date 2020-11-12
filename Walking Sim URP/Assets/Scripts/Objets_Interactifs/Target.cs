using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool shine;

  
    public void Shine()
    {
        shine = true;
        GetComponent<Outline>().enabled = true;
    }

    public void StopShine()
    {
        shine = false;
        GetComponent<Outline>().enabled = false;
    }
}
