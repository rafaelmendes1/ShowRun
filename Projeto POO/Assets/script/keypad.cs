using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public AudioSource sound, abrir;
    public Animator trave;
    
    public TextMesh text;
    public string senha = "7235";
        //"77235";
    private string userInput = "";
    private string text1;
    private int Max = 4;
    public bool zerar;

    private void Start()
    {
        
        userInput = "";
        text.text = "";
        zerar = false;
    }


    public void ButtonClicked(string number)
    {
        userInput += number;
        text.text = "" + userInput;
        text1 = text.text;
        CheckString();
     


    }
    void CheckString()
    {
        if (text.text.Length > 4)
        {
           
            text1 = text1.Substring(0, Max);
                       
        }
        text.text = text1;
    }
    public void cancel()
    {
        userInput = "";
        text.text = "";
    }
    public void confirm()
    {
        if (userInput == senha)
        {
            text.text = "ACCEPT";

            abrir.Play();
            trave.Play("abrirporta");
            Cursor.lockState = CursorLockMode.None;

            userInput = "";
           
        }
        else
        {
            //som de erro
            sound.Play();
            text.text = "ERROR";
            
            userInput = "";
        }
    }

     void Update()
    {
      if(zerar == true)
        {
            clearinput();
        } 
    }
    public void clearinput()
    {
        text.text = "";
    } 
}
