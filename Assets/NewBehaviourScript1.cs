using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()    
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalmovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalmovement);
        rb.AddForce(movement * speed * Time.deltaTime);
    }
}
