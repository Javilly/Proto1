using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatScript : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(10);
        rb.isKinematic = false;
    }
}
