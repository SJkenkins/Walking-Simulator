using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{

   // public GameObject book;
    /*public Texture[] textures;
    public int currentTexture;*/

    public int nbPage;    

    public Book Book;



    public void TakePage()
    {
        Book.ReplacePage(nbPage);
        Destroy(gameObject);

        /* currentTexture++;
         currentTexture %= textures.Length;
         GetComponent<Renderer>().material.mainTexture = textures[currentTexture]; */

    }
}
