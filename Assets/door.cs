using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Animator animator;
    bool doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorOpen = true;
            Doors("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (doorOpen)
        {
            doorOpen = false;
            Doors("Close");
        }
    }

    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
