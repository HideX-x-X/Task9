using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private bool readyGround;
    [SerializeField] private int forceJump;
    [SerializeField] private Collider2D headCollider;
   




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
  
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            readyGround = true;
        }
        else
        {
            readyGround = false;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
    
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
           
            if (readyGround)
            {


                rb.AddForce(new Vector2(0, forceJump));
               
                readyGround = false;
            }
      
        }
        if (Input.GetKey(KeyCode.C))
        {
            headCollider.enabled = false;
        }
        else
        {
            headCollider.enabled = true;
        }
        }
}
    