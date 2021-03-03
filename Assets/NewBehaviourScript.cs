using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to the game ");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(0, 10, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(0, -10, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(0, 0, 10);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(0, 0, -10);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale = new Vector3(cube.localScale.x,cube.localScale.y+1,cube.localScale.z );
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.localScale = new Vector3(1,1,1);
        }
    }
}
