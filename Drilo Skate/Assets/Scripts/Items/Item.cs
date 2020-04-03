using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip itemSoundClip;
    public float itemSoundVolume;

    public GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            if(gameManager.GetComponent<GameManager>().musicOnOff == true)
            {
                AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
            }
        }
        Destroy(gameObject);
    }
}
