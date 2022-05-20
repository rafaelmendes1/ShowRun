using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lugaresanim : MonoBehaviour
{
    
    public bool liberado, trava, chavez = false, chave2 = false, chave3 = false, fusivelr = false;
   
    void Update()
    {
        if(liberado == true|| fusivelr == true|| chave2 == true || chavez == true || chave3 == true)
        {
            trava = true;
        }
        else
        {
            trava = false;
        }
       
    }
}
