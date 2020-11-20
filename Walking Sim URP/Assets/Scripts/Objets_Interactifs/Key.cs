using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    KeyManager KeyManager;
    public GameObject this_key;

    private void Start()
    {
        KeyManager = GameObject.FindGameObjectWithTag("Player").GetComponent<KeyManager>();
    }

    public void TakeKey()
    {
        KeyManager.GainKey(this_key);
        Destroy(gameObject);
    }



}