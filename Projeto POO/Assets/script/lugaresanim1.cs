using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class lugaresanim1 : MonoBehaviour
{
    public lugaresanim travarrr; 
    public Animator item;
    public bool ativar = false, liberar;
    public string animacaonormal = "";
    public string animacaoreversa = "";

    public UnityEvent clicked;
    private void OnMouseDown()
    {
        if (travarrr.trava == true)
        {
            clicked.Invoke();
        }
      
    }
    private void Start()
    {
        
    }

    public void travas()
    {
       

        liberar = !liberar;

    }
     
      
    public void anima()
    {

        if (liberar == true)
        {
            
            item.Play(animacaonormal);
           
        }
        else
        {
            
            item.Play(animacaoreversa);


        }
        
    }
   
}
