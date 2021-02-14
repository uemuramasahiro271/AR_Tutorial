using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanScript : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Walk_F", true);
        }
        else
        {
            anim.SetBool("Walk_F", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Walk_B", true);
        }
        else
        {
            anim.SetBool("Walk_B", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Walk_R", true);
        }
        else
        {
            anim.SetBool("Walk_R", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Walk_L", true);
        }
        else
        {
            anim.SetBool("Walk_L", false);
        }
    }
}
