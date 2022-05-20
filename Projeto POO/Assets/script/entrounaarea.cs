using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrounaarea : MonoBehaviour
{
    public movimento parou;
    public objetos obj;
    public trocacamera trocou;
    public lugaresanim travas;
    public GameObject personagem;
    public cam trv;
    public bool interagiti, usarf = false;
  

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "senhaarea")
        {
            obj.areadeusobotao = true;
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                trv.trav = true;
                trocou.c1.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c1.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "armariosesq")
        {
            
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                travas.liberado = true;
                trv.trav = true;
                trocou.c3.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                travas.liberado = false;
                interagiti = false;
                trv.trav = false;
                trocou.c3.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (other.gameObject.name == "armariosdir")
        {
           
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                travas.liberado = true;
                trv.trav = true;
                trocou.c4.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                travas.liberado = false;
                interagiti = false;
                trv.trav = false;
                trocou.c4.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (other.gameObject.name == "armariosmeio")
        {
           
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                travas.liberado = true;
                trv.trav = true;
                trocou.c2.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                travas.liberado = false;
                interagiti = false;
                trv.trav = false;
                trocou.c2.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "armag1")
        {

            travas.chave2 = false;
            travas.chave3 = false;
            travas.fusivelr = false;

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                travas.liberado = true;
                trv.trav = true;
                trocou.c5.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                travas.liberado = false;
                interagiti = false;
                trv.trav = false;
                trocou.c5.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "armag2")
        {
            travas.chave2 = false;
            travas.chave3 = false;
            travas.fusivelr = false;

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                travas.liberado = true;
                trv.trav = true;
                trocou.c6.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                travas.liberado = false;
                interagiti = false;
                trv.trav = false;
                trocou.c6.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "armag3")
        {
            travas.chave2 = false;
            travas.chave3 = false;
            travas.fusivelr = false;
            obj.areadeuso1cadeado = true;
            if (obj.cadchav == true)
            {
                travas.chavez = true;
            }

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.cadchav == true)
                {
                    travas.chavez = true;
                }
                parou.trave = true;
                
                trv.trav = true;
                trocou.c7.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                if (obj.fu == true)
                {
                    travas.chavez = false;
                }
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c7.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "gavetasg1")
        {
            obj.areadeusochav1 = true;
            travas.chave2 = false;
            travas.chavez = false;
            travas.fusivelr = false;

            if (obj.chv3 == true)
            {
                travas.chave3 = true;
            }
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.chv3 == true)
                {
                    travas.chave3 = true;
                }
                parou.trave = true;
                
                trv.trav = true;
                trocou.c8.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.chave3 = false;
           
                parou.trave = false;
                
                interagiti = false;
                trv.trav = false;
                trocou.c8.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "gavetasg2")
        {
            obj.areadeusochav1 = true;
            travas.chave2 = false;
            travas.chavez = false;
            travas.fusivelr = false;

            if (obj.chv3 == true)
            {
                travas.chave3 = true;
            }
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.chv3 == true)
                {
                    travas.chave3 = true;
                }
                parou.trave = true;
                
                trv.trav = true;
                trocou.c9.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.chave3 = false;
                parou.trave = false;
               
                interagiti = false;
                trv.trav = false;
                trocou.c9.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "gavetasm1")
        {
            obj.areadeuso3chav2 = true;
            travas.chave3 = false;
            travas.chavez = false;
            travas.fusivelr = false;
            if (obj.cve2 == true)
            {
                travas.chave2 = true;
            }
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.cve2 == true)
                {
                    travas.chave2 = true;
                }
                parou.trave = true;
                
                trv.trav = true;
                trocou.c10.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.chave2 = false;
           
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c10.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "gavetasm2")
        {
            obj.areadeuso3chav2 = true;
            travas.chave3 = false;
            travas.chavez = false;
            travas.fusivelr = false;

            if (obj.cve2 == true)
            {
                travas.chave2 = true;
            }
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.cve2 == true)
                {
                    travas.chave2 = true;
                }
                parou.trave = true;
                trv.trav = true;
                trocou.c11.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.chave2 = false;
               
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c11.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "gavetasm3")
        {
            obj.areadeuso3chav2 = true;
            travas.chave3 = false;
            travas.chavez = false;
            travas.fusivelr = false;
            if (obj.cve2 == true)
            {
                travas.chave2 = true;
            }
            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                if (obj.cve2 == true)
                {
                    travas.chave2 = true;
                }
                parou.trave = true;
                trv.trav = true;
                trocou.c12.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.chave2 = false;
                
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c12.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "poster1")
        {

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                trv.trav = true;
                trocou.c13.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c13.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "poster2")
        {

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                trv.trav = true;
                trocou.c14.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c14.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "poster3")
        {

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                trv.trav = true;
                trocou.c15.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c15.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "poster4")
        {

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                trv.trav = true;
                trocou.c16.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                parou.trave = false;
                interagiti = false;
                trv.trav = false;
                trocou.c16.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (other.gameObject.name == "raiox")
        {
            obj.areadeusoraiox = true;
            travas.chave3 = false;
            travas.chavez = false;
            travas.chave2 = false;
            if (obj.fu == true)
            {
                travas.fusivelr = true;
               
            }

            usarf = true;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                personagem.SetActive(false);
                parou.trave = true;
                if(obj.fu == true)
                {
                  travas.fusivelr = true;
                    obj.x = true;
                }
                trv.trav = true;
                trocou.c17.SetActive(true);
                interagiti = true;
                Cursor.lockState = CursorLockMode.None;
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                personagem.SetActive(true);
                travas.fusivelr = false;
                obj.x = true;
                parou.trave = false;    
                interagiti = false;
                trv.trav = false;
                trocou.c17.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
