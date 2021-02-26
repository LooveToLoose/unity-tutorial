using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeJump : MonoBehaviour
{
    [SerializeField]
    float jumpForce;

    [SerializeField]
    KeyCode jumpKey;

    bool onTheGround = true;

    float jumpXVelocity = 0;
    float jumpZVelocity = 0;

    private void OnCollisionEnter(Collision collision)
    {
        onTheGround = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(jumpKey) && onTheGround) {
            GetComponent<Rigidbody>().velocity += new Vector3(0, jumpForce, 0);
            onTheGround = false;
            jumpXVelocity = GetComponent<Rigidbody>().velocity.x;
            jumpZVelocity = GetComponent<Rigidbody>().velocity.z;
        }

        if(!onTheGround){
            GetComponent<Rigidbody>().velocity = new Vector3(jumpXVelocity, GetComponent<Rigidbody>().velocity.y, jumpZVelocity);
        }
        
    }
}
