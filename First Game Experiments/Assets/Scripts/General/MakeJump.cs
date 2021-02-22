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
        }
    }
}
