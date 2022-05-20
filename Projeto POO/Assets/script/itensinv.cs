using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itensinv : MonoBehaviour
{
    private string slotnumb1 = "1", slotnumb2 = "2", slotnumb3 = "3", slotnumb4 = "4", slotnumb5 = "5", slotnumb6 = "6", slotnumb7 = "7", slotnumb9 = "9", slotnumb10 = "10", slotnumb11 = "11";
    public string userInput = "";
    public GameObject menula;
    public objetos obj;
    public entrounaarea traba;


    // Start is called before the first frame update
    void Start()
    {
        userInput = "";
    }
    public void ButtonClicked(string number)
    {
        userInput = number;

    }
    // Update is called once per frame
    public void grade()
    {

        if (userInput == slotnumb1 && traba.usarf == true)
            {
                obj.raiox11();
            }
            if (userInput == slotnumb2 && traba.usarf == true)
            {
                obj.raiox22();
            }
            if (userInput == slotnumb3 && traba.usarf == true)
            {
                 obj.raiox33();
            }
            if (userInput == slotnumb4 && traba.usarf == true)
            {
                obj.usaregavetam();
            }
            if (userInput == slotnumb5 && traba.usarf == true)
            {
                obj.usargavetag();
            }
            if (userInput == slotnumb6 && traba.usarf == true)
            {
                obj.lanternaa();
                
        }
            if (userInput == slotnumb7 && traba.usarf == true )
            {
                obj.ligarmaquina();
            }
          
            if (userInput == slotnumb9 && traba.usarf == true && obj.lanterna >=1 )
            {
            
                obj.recarga();
            }
            if (userInput == slotnumb10 && traba.usarf == true)
            {
                obj.achoubotao();
            }
            if (userInput == slotnumb11 && traba.usarf == true)
            {
                obj.usararmariola();
            }

        if (Input.GetMouseButton(1))
        {
            userInput = "";
        }

    }

}
