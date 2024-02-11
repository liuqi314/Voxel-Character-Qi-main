using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BaseMovement : MonoBehaviour
{


    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;
    protected Rigidbody myRigidbody;

    

     
    // Start is called before the first frame update
    void Awake()
    
    
    {
        myRigidbody = GetComponent<Rigidbody>();
        
        if (!myRigidbody)
        {
            myRigidbody = GetComponent<Rigidbody>();

        }
        

    }

    public void Move(Vector3 moveDirection)
    {
        myRigidbody.velocity = moveDirection.normalized * moveSpeed;  

    }
   




}
