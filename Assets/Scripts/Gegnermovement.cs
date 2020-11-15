using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gegnermovement : MonoBehaviour
{

 
    public bool Cground = false;
    Vector3 movement;
  

    void Start()
    {
        movement = transform.position;
    }
    void Update()
    {
        movement.x -=  0.005f;


        transform.position = new Vector3(movement.x, transform.position.y, transform.position.z);




    }





    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
           
          
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
               

          
            
        }
    }
}
