using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float zInput;
    private float turnSpeed = 5;
   

    public int coinCount;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed * verticalInput);

        if(coinCount == 10)
        {
            //code for powerup?
        }


    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Currency")
        {
            coinCount++;
        }
    }
}
