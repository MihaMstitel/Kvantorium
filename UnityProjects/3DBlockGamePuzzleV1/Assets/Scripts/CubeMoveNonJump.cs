using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CubeMoveNonJump : MonoBehaviour
{
    bool walkRight;

    bool walkLeft;
    [SerializeField] Vector3 MoveVector;

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
        if(walkRight ==true) 
        {
            GetComponent<Rigidbody>().velocity += MoveVector;
        } 

        if(walkLeft ==true) 
        {
            GetComponent<Rigidbody>().velocity -= MoveVector;
        } 
    
    }







    //[SerializeField] KeyCode KeyLeft;

    //[SerializeField] KeyCode KeyRight;

    
    
    //private void FixedUpdate()
    //{
        //if(Input.GetKey(KeyLeft))
        //{
            //GetComponent<Rigidbody>().velocity += MoveVector;
        //}

        //if(Input.GetKey(KeyRight))
        //{
            //GetComponent<Rigidbody>().velocity -= MoveVector;    
        //}

    //}

}
