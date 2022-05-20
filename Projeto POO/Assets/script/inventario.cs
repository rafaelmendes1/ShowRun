using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    public objetos obj;

    public GameObject box0, box1, box2, box3, box4, box5, box6, box7, box8, box9, box10, box11;
 
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (obj.chav1 >=1) 
        {
            box4.SetActive(true);
        }
        else
        {
            box4.SetActive(false);
        }
        if (obj.lanterna >= 1) 
        {
            box6.SetActive(true);
        }
        else
        {
            box6.SetActive(false);
        }
        if (obj.chave2 >= 1) 
        {
            box5.SetActive(true);
        }
        else
        {
            box5.SetActive(false);
        }
        if (obj.pilha >= 1) 
        {
            box9.SetActive(true);
        }
        else
        {
            box9.SetActive(false);
        }
        if (obj.fusiv >= 1) 
        {
            box7.SetActive(true);
        }
        else
        {
            box7.SetActive(false);
        }
        if (obj.xraio1 >= 1) 
        {
            box2.SetActive(true);
        }
        else
        {
            box2.SetActive(false);
        }
        if (obj.xraio2 >= 1) 
        {
            box3.SetActive(true);
        }
        else
        {
            box3.SetActive(false);
        }
        if (obj.butto >= 1)
        {
            box10.SetActive(true);
        }
        else
        {
            box10.SetActive(false);
        }
        if (obj.xraio >= 1) 
        {
            box1.SetActive(true);
        }
        else
        {
            box1.SetActive(false);
        }
        if (obj.cadeadochave >= 1) 
        {
            box11.SetActive(true);
        }
        else
        {
            box11.SetActive(false);
        }
    }
}
