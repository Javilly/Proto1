using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour {

    public static MyGameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    /*
    public void restarVida()
    {
        if (vida > 0)
        {
            vida--;
            Debug.Log("Vida del personaje: " + vida);
        }
    }
    */
}
