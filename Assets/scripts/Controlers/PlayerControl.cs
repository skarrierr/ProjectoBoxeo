using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController Control;
    private Vector3 MoveDir = Vector3.zero;
    public float Gravity, SpeedRotation, SpeedMove;



    // Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<CharacterController>();
    
    }

    // Update is called once per frame
    void Update()
    {
        {
            MoveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            MoveDir = transform.TransformDirection(MoveDir);
            MoveDir *= SpeedMove;

            transform.Rotate(Vector3.up * SpeedRotation * Input.GetAxis("Horizontal") * Time.deltaTime);

        }

        MoveDir.y -= Gravity * Time.deltaTime;
        Control.Move(MoveDir * Time.deltaTime);
    }
}
