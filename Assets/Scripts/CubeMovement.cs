using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    /*public Rigidbody RB;
    public float speed;
    public bool jumpKeyWasPressed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>(); 
            
    } 
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            jumpKeyWasPressed=true;
        }
    }
    void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            RB.AddForce(new Vector3(0, 0, speed));
        }
    }*/
    private CharacterController cc;
    public Vector3 ccMoveForward, ccMoveSide;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cc.Move(ccMoveForward);
        }
    }
}
