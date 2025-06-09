using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{

    public Animator intrANM;
    private bool intr;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            intr = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        intr = false;
    }


    void Update()
    {


        if (intr)
        {
            intrANM.SetBool("gunB", true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
                change.Instance.chs = 1;
            }
        }
        else
        {
            intrANM.SetBool("gunB", false);
        }
    }

}