using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    Quaternion angle;
    public float rotate_spd = 3;
    public float spd = 5;
    public float gravity = 1;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            angle.eulerAngles += new Vector3(-rotate_spd, 0, 0);
            this.GetComponent<Transform>().rotation = angle;
        }
        if (Input.GetKey(KeyCode.S))
        {
            angle.eulerAngles += new Vector3(rotate_spd, 0, 0);
            this.GetComponent<Transform>().rotation = angle;
        }
        if (Input.GetKey(KeyCode.A))
        {
            angle.eulerAngles += new Vector3(0, -rotate_spd, 0);
            this.GetComponent<Transform>().rotation = angle;
        }
        if (Input.GetKey(KeyCode.D))
        {
            angle.eulerAngles += new Vector3(0, rotate_spd, 0);
            this.GetComponent<Transform>().rotation = angle;
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(this.GetComponent<Transform>().forward * spd);
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(this.GetComponent<Transform>().forward * (-spd));
        }
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(this.GetComponent<Transform>().right * (-spd));
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(this.GetComponent<Transform>().right * spd);
        }
        controller.Move(new Vector3(0, -gravity * Time.deltaTime, 0));
    }
}
