using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public KeyManager KeyManager;
    public GameObject this_key;



    public void TakeKey()
    {
        KeyManager.GainKey(this_key);
        Destroy(gameObject);
    }



}