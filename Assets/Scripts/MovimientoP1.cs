using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovimientoP1 : NetworkBehaviour
{

    public float speed;

    private Rigidbody rb;

    private bool isBig = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal P1");
            float moveVertical = Input.GetAxis("Vertical P1");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Cmd_Grow();
            }
        }
        if (transform.position.y <= -2)
        {
            Destroy(this.gameObject);
        }
    }

    [Command]
    private void Cmd_Grow()
    {
        if (!isBig)
        {
            int scalingFramesLeft = 100;
            while (scalingFramesLeft > 0)
            {
                //print("wea" + scalingFramesLeft);
                transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale * 1.05f, Time.deltaTime * 5);
                scalingFramesLeft--;
            }
            isBig = true;
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
            isBig = false;
        }
        print("Wea");
        
    }
}
