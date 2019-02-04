using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Movement = Camera.transform.TransformDirection(Movement);
        rb.AddForce(Movement * speed);

   
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hit")
        {
            //print("Ouch");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
