using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour
{

    public bool Cground = false;
    Vector3 movement;
    bool links = true;


    void Update()
    {
        movement = transform.position;
       /// Debug.Log("Text: " + movement.x);
        if (movement.x < -55 || movement.x > -30)
        {
           
            links = !links;
        }

        if (links)
        {
            movement.x -= 0.02f;
        }
        else
        {
            movement.x += 0.02f;
        }

        transform.position = new Vector3(movement.x, transform.position.y, transform.position.z);


    }



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {

            other.collider.transform.SetParent(transform);


        }
    }



    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {

            other.collider.transform.SetParent(null);


        }
    }

}
