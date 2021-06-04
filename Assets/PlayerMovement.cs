using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpSpeed;
    public float playerspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //JumpMovement();
        this.GetComponent<Rigidbody>().velocity = new Vector3(playerspeed*Time.deltaTime, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
    }
    private void OnCollisionStay(Collision collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Ground"))
        {
            JumpMovement();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ObstacleController>()!=null)
        {
            Destroy(this.gameObject);
            // print("end");
        }
    }
    private void JumpMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
            
        }
    }
}
