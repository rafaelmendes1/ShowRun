using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class anima : MonoBehaviour
{
    public movimento mov;
    Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetBool("walk", true);

           if (mov.vel == mov.correr)
          {
                anim.SetBool("correr", true);
            }
           else
           {
                anim.SetBool("correr", false);
            }
        }
        else
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            anim.SetBool("bwalk", true);
        }
        else
        {
            anim.SetBool("bwalk", false);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            anim.SetBool("direita", true);
        }
        else
        {
            anim.SetBool("direita", false);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("esquerda", true);
        }
        else
        {
            anim.SetBool("esquerda", false);
        }
    }
}
