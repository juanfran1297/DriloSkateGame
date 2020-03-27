using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool pausa;
    // Start is called before the first frame update
    void Start()
    {
        pausa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pausa)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;
    }

    public void Pausa()
    {
        pausa = !pausa;
    }
}
