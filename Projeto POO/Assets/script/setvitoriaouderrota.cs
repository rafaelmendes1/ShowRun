using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setvitoriaouderrota : MonoBehaviour
{
    public GameObject parabens;
    // Start is called before the first frame update
    void Start()
    {
        parabens.SetActive(false);
    }

    // Update is called once per frame
    public void vitoria()
    {
        parabens.SetActive(true);
    }

    public void derrota()
    {

    }
}
