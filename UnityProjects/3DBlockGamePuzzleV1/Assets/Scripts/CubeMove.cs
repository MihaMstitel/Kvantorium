using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] Vector3 MoveVector;
    
    public int jumpHeight = 8;
    //private bool isJumped = false;

    bool walkRight;

    bool walkLeft;
    private Rigidbody rb;

    bool jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("Jump", 3);
    }
    //private void FixedUpdate()
    //{
        //if(Input.GetKey(KeyLeft))
       // {
            //GetComponent<Rigidbody>().velocity += MoveVector;
        //}

        //if(Input.GetKey(KeyRight))
        //{
            //GetComponent<Rigidbody>().velocity -= MoveVector;    
        //}


    public void pointerDownRight()
    {
        walkRight = true ;
    }

    public void pointerUpRight()
    {
        walkRight = false ;
    }

    
    public void pointerDownLeft()
    {
        walkLeft = true ;
    }

    public void pointerUpLeft()
    {
        walkLeft = false ;
    }
    


    void FixedUpdate() 
    {
        if(walkRight == true) 
        {
            GetComponent<Rigidbody>().velocity += MoveVector;
        } 

        if(walkLeft == true) 
        {
            GetComponent<Rigidbody>().velocity -= MoveVector;
        } 
    
    }


    public void Jump()
    {
        {
            rb.velocity = new Vector3(0, jumpHeight, 0);
        }

    }
   
}
