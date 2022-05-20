using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetos : MonoBehaviour
{
    public movimento mov;
    public itensinv input;
    public Light lights;
    public inventario inv;
    public lugaresanim destravar;
    // chave, chaves, uv, raiox, lamina, fusivel, pilha, botao

    public float chav1, chave2, cadeadochave, fusiv, lanterna, pilha, butto, xraio, xraio1, xraio2 = 0;

    public GameObject cadeade, chavess, chavee2, chacadeado, lantern, pilh, botao, inve, keypad, fusi, raio2x, raio1x, raio3x;
    public bool ativar, luz, chavee = false, cadchav = false, cve1 = false, cve2 = false, chv3 = false, fu =false;
    public bool areadeusobotao = false, areadeusochav1 = false, areadeuso3chav2 = false, areadeuso1cadeado = false, areadeusoraiox =false,x = false;
    public GameObject um, dois, tres;
    public void raiox()
    {

            xraio++;
        input.userInput = "1";
        raio3x.SetActive(false);

    }

    public void raiox1()
    {

        xraio1++;
        input.userInput = "2";
        raio1x.SetActive(false);

    }
    public void raiox2()
    {

        xraio2++;
        input.userInput = "3";
        raio2x.SetActive(false);

    }
    public void chave()
    {

            chav1++;

        chavess.SetActive(false);

        input.userInput = "4";


    }
    public void chaves()
    {

            chave2++;
        input.userInput = "5";
        chavee2.SetActive(false);
    }
    public void flashlight()
    {

            lanterna++;

        lantern.SetActive(false);
        input.userInput = "6";


    }
    public void fusivel()
    {

            fusiv++;
        input.userInput = "7";
        fusi.SetActive(false);
    }
    public void pilhas()
    {
        
        pilha++;
        pilh.SetActive(false);
        input.userInput = "9";
        

    }
    public void butao()
    {
        butto++;
        botao.SetActive(false);
        
        print(input.userInput);
        input.userInput = "10";
    }
    public void cadeado()
    {
        cadeadochave++;
        input.userInput = "11";
        chacadeado.SetActive(false);
    }


    // script enteritens

    public void recarga()
    {
        pilha--;
        luz = true;
        if(pilha <= 0)
        {
            inv.box9.SetActive(false);
        }
    }
    public void achoubotao()
    {
     if (areadeusobotao == true)
        {
            keypad.SetActive(true);
            butto--;
            if (butto <= 0)
            {
                inv.box10.SetActive(false);
            }
        }  
        
    }
    public void usaregavetam()
    {
        if (areadeuso3chav2 == true)
        {
            cve2 = true;
        }

    }
    public void usararmariola()
    {
        if(areadeuso1cadeado == true)
        {
            cadeadochave--;
            cadchav = true;
            cadeade.SetActive(false);
        }
       
    }
    public void usargavetag()
    {
        if (areadeusochav1 == true)
        {
            chv3 = true;
        }
    }
    public void lanternaa()
    {
        
        if (luz == true)
        {
            
            ativar = !ativar;
        }
            
        if(ativar == true)
        {
            
            lights.enabled = true;
        }
        else
        {
            lights.enabled = false;
        }
    }
    public void ligarmaquina()
    {

        if(areadeusoraiox == true)
        {
            fu = true;
            fusiv--;
            if (fusiv <= 0)
            {
                inv.box7.SetActive(false);
            }
        }
       
    }
    public void raiox11()
    {
        if (areadeusoraiox == true)
        {
            if(x == true)
            {
                um.SetActive(true);
                dois.SetActive(false);
                tres.SetActive(false);
            }
          
        }
    }
    public void raiox22()
    {
        if (areadeusoraiox == true)
        {
            if (x == true)
            {
                dois.SetActive(true);
                um.SetActive(false);
                tres.SetActive(false);
            }
          
        }
    }
    public void raiox33()
    {
        if (areadeusoraiox == true)
        {
              if(x == true)
              {
                 tres.SetActive(true);
                 dois.SetActive(false);
                 um.SetActive(false);
              }
           
        }
    }
}

