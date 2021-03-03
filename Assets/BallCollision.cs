using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollision : MonoBehaviour
{
    public Material[] wallMat;
    Renderer rend;
    public Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        displayText.text = "";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            displayText.text = "You hit the wall!!";
            rend.sharedMaterial = wallMat[1];
           
        }
        if(collision.gameObject.name=="Ball 2")
        {
            displayText.text = "You hit the wall!!";
            rend.sharedMaterial = wallMat[2];
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ball"|| collision.gameObject.name == "Ball 2")
        {
            rend.sharedMaterial = wallMat[0];
            displayText.text = "Keep rolling!!";
            
        }
       else if (collision.gameObject.name == "Ball" || collision.gameObject.name != "Ball 2")
        {
            rend.sharedMaterial = wallMat[2];
            displayText.text = "Keep rolling!!";

        }
        else if (collision.gameObject.name != "Ball" || collision.gameObject.name == "Ball 2")
            {
                rend.sharedMaterial = wallMat[1];
                displayText.text = "Keep rolling!!";

            }
    }
}
