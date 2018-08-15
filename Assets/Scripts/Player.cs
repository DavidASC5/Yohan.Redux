using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    public float speed;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKey(KeyCode.W))
        { transform.Translate(0, speed * Time.deltaTime, 0); anim.SetInteger("Dir", 0); anim.speed = 1; }
        else if (Input.GetKey(KeyCode.S))
        { transform.Translate(0, -speed * Time.deltaTime, 0); anim.SetInteger("Dir", 1); anim.speed = 1; }
        else if (Input.GetKey(KeyCode.A)) 
        { transform.Translate(-speed * Time.deltaTime, 0, 0); anim.SetInteger("Dir", 2); anim.speed = 1; }
        else if (Input.GetKey(KeyCode.D))
        { transform.Translate(speed * Time.deltaTime, 0, 0); anim.SetInteger("Dir", 3); anim.speed = 1; }
        else
        {
            anim.speed = 0;
        }
    }
    void Movement()
    {

    }

}