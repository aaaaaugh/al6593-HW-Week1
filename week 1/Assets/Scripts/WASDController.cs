using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{

    public float forceAmt = 10;

    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //calls out to the component Rigidbody attached to Player gameobject. 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //press W every frame
        {
            rb.AddForce(Vector3.forward * forceAmt); //controls physics of the player. gentle force
        }
    }
}
