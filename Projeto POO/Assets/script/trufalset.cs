using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trufalset : MonoBehaviour
{
    public vuzualiza viz;
 
    public GameObject pag1um, pag2um, pag3um;
    public GameObject pag1dois, pag2dois, pag3dois;
    public GameObject pag1tres, pag2tres;
    public GameObject pag1quatro, pag2quatro, pag3quatro;

    // Update is called once per frame
    void Update()
    {
        if(viz.a == 3)
        {
            //r84
            
            pag1tres.SetActive(true);
            pag2tres.SetActive(true);

        }
        else
        {
            pag1tres.SetActive(false);
            pag2tres.SetActive(false);
        }
        if (viz.a == 2)
        {
           
            //m49
            pag1um.SetActive(true);
            pag2um.SetActive(true);
            pag3um.SetActive(true);

        }
        else
        {
            pag1um.SetActive(false);
            pag2um.SetActive(false);
            pag3um.SetActive(false);
        }
        if (viz.a == 4)
        {
           ;
            //j50
            pag1dois.SetActive(true);
            pag2dois.SetActive(true);
            pag3dois.SetActive(true);
        }
        else
        {
            pag1dois.SetActive(false);
            pag2dois.SetActive(false);
            pag3dois.SetActive(false);
        }
        if (viz.a == 6)
        {
            
            //e26
            pag1quatro.SetActive(true);
            pag2quatro.SetActive(true);
            pag3quatro.SetActive(true);
        }
        else
        {
            pag1quatro.SetActive(false);
            pag2quatro.SetActive(false);
            pag3quatro.SetActive(false);
        }


    }
}
