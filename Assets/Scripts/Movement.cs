using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    // public member eines Scripts können bequem
    // im Unity Editor gesetzt und auch während
    // das Spiel getestet wird verändert werden.

    public Animator animator;

    //buffs start
    public bool dauerHuepfen;
    public float rechtsLinksVertauschen; //1 == normal oder -1 == vertauscht
    public float Geschwindigkeit;
    public bool frozen = false;
    //buffs ende
    public Rigidbody2D rb2d;
    public bool Cground = false;
    private float wait = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (frozen == false)
        {
            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            animator.SetBool("Jump", !Cground);

            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
            if ((dauerHuepfen == true))
            {
                Jump();
            }
            Vector3 movement = new Vector3((Input.GetAxis("Horizontal") * rechtsLinksVertauschen), 0f, 0f);
            transform.position += movement * Time.deltaTime * Geschwindigkeit;
        }
        if (Input.GetKeyUp("x"))
        {
            frozen = true;
            animator.SetBool("Frozen", true);
            wait = 10.0f;
        }
        else
        {
            if (wait < 0)
            {
                wait = 0;
                animator.SetBool("Frozen", false);
                frozen = false;
            }
            else if (wait > 0)
            {
                wait -= Time.deltaTime;
            }

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenü");
        }

    }
    void Jump()
    {
        if (Cground == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
            Cground = false;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Cground = true;

    }
}
