using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vuzualiza : MonoBehaviour
{
    public cam cam;
    public movimento mov;
    public zoom zo;
    public float fic, a;
    public GameObject carta, ficha1, ficha2, ficha3, ficha4, ficha5;
    public bool trava; 
    public GameObject lercarta, lerficha1, lerficha2, lerficha3, lerficha5;
    public GameObject v, z, x;
    // Start is called before the first frame update
    void Start()
    {
       
        trava = false;
    }

    // Update is called once per frame
    public void leitura1()
    {
        fic = 1;
         trava = true;
        mov.trave = true;
        cam.trav = true;
       
        
    }
    public void leitura2()
    {
        //m49
        a = 2;
        mov.trave = true;
        cam.trav = true;
        fic = 2;
        trava = true;
       
    }
    public void leitura3()
    {
        //r84
        a = 3;
        mov.trave = true;
        cam.trav = true;
        fic = 3;
        trava = true;
       
    }
    public void leitura4()
    {
        //j50
        a = 4;
        mov.trave = true;
        cam.trav = true;
        fic = 4;
        trava = true;

    }

    public void leitura5()
    {
        mov.trave = true;
        cam.trav = true;
        fic = 5;
        trava = true;
       
    }
    public void leitura6()
    {
        //e26
        a = 6;
        mov.trave = true;
        cam.trav = true;
        fic = 6;
        trava = true;

    }


    public void Update()
    {

        if (fic == 1)
        {
            lercarta.SetActive(true);

        }
        else
        {
            lercarta.SetActive(false);

        }
      


        if (fic == 5)
        {
            lerficha5.SetActive(true);

        }
        else
        {
            lerficha5.SetActive(false);

        }


        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (fic == 1 || fic == 2 || fic == 3 || fic == 4 || fic == 5 || fic == 6)
            {
                zo.insp = true;
                mov.trave = false;
                cam.trav = false;
                fic = 0;


            }
        }
    }
}

    

       