using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarEscenario : MonoBehaviour
{

    public GameObject[] LevelPart;

    public bool puedoInstanciar = true;

    public Transform siguienteSpawn;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        siguienteSpawn = transform.Find("PosicionSiguiente");
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - 25 > siguienteSpawn.position.x))
        {
            Destroy(gameObject);
        }

        if (puedoInstanciar == true && transform.position.x < (player.transform.position.x + 25))
        {
            CrearEscenario();
            puedoInstanciar = false;
        }
    }

    private void CrearEscenario()
    {
        var randomLevel = Random.Range(0, LevelPart.Length);

        Instantiate(LevelPart[randomLevel], siguienteSpawn.position, Quaternion.identity);
    }
}
