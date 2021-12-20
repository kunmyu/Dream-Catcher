using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
   public float moveSpeed = 5f;
    public Vector3 x, y;
    Vector3 forward, right;
    Rigidbody rb;
    public bool ContinueWalk = false;

    

   
    // Start is called before the first frame update
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }

    }

    public void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
      


        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

       

        Vector3 heading = Vector3.Normalize(upMovement + rightMovement);
     
        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
     


    }


}
  
