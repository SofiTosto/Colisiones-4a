using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movementspeed;
    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            //transform.position += new Vector3(0, 0, 0.1f);
            transform.Translate (0, 0, movementspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
          
            transform.Translate(0, 0, -movementspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(0, rotationspeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(0, -rotationspeed, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
       if( col.gameObject.name == "muerte")
        {
            Destroy(gameObject);
        }
         

    }
}
   