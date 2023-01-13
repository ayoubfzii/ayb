using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed = 5f;
    private Animator playeranimator;
    public float jumping = 5f; 
    Rigidbody rb;
    private float movespeed2 = 2f;
    private float movespeed3 = 3f;

    private void Awake()
    {
        playeranimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {                    
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playeranimator.SetBool("run", true);
            transform.Translate(new Vector3(0, 0, movespeed * Time.deltaTime));
        }
            if (Input.GetKey(KeyCode.LeftArrow))
        {
            playeranimator.SetBool("run", true);
            if (this.gameObject.transform.position.x > levelboundry.leftside)
            {
                transform.Translate(new Vector3  (-1 * movespeed * Time.deltaTime, 0, movespeed3 * Time.deltaTime));
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundry.rightside)
            {
                playeranimator.SetBool("run", true);
                transform.Translate(new Vector3(1 * movespeed * Time.deltaTime, 0, movespeed3 * Time.deltaTime));
              
            }
        }
        //if (!Input.GetKey(KeyCode.UpArrow))
        //{
        //    playeranimator.SetBool("run", false);
     
        //}
        // if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    playeranimator.SetBool("jump", true);
        //  //  transform.Translate(new Vector3(0, jumping*Time.deltaTime, 0));
        //}
        //else if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    playeranimator.SetBool("jump", false);
        //    //transform.Translate(new Vector3(0, -jumping*Time.deltaTime, 0));
        //}


    }
}
