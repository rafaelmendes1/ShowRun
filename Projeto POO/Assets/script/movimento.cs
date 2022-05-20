using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class movimento : MonoBehaviour
{

    public CharacterController controle;
    public esc res;
    //  public inventario inventario;

    //public AudioSource sound;
    public bool travis;
    public float vel;
    public float andar = 2f;
    public float correr = 3.5f;
    public float tempo = 60;
    public float gravidade;
    public float x;
    public float z;
    public bool hepl;
    public bool trave, trava;
    


    Vector3 velocidade;


    // Start is called before the first frame update
    void Start()
    {
        trave = false;
    }


 
    // Update is called once per frame

    void Update()
    {
       
        if (trave == false)
        {

            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");

            Vector3 mover = transform.right * x + transform.forward * z;

            controle.Move(mover * vel * Time.deltaTime);

            velocidade.y += gravidade * Time.deltaTime;
            controle.Move(velocidade);

        }
        else
        {
            x = 0;
            z = 0;
        }
       

        
        if (Input.GetKey(KeyCode.LeftShift) && z == 1 && tempo > 0)
        {

            hepl = true;
            tempo--;
            vel = correr;


        }
        else
        {
            vel = andar;
            hepl = false;
        }

        if (vel == correr)
        {
            trava = false;
            StopCoroutine(sprint());
        }

        if (vel == andar)
        {
            trava = true;
            StartCoroutine(sprint());
        }

        if (tempo > 60)
        {

            trava = false;
            StopCoroutine(sprint());

        }


        IEnumerator sprint()
        {

            if (tempo < 60)
            {

                if (trava == true)
                {
                    yield return new WaitForSeconds(2);
                    tempo++;
                }

            }

            if (tempo >= 59)
            {
                tempo = 60;
                trava = false;
            }

        }
        
        
    }
   

  
}
   