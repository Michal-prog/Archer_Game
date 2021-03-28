using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoad : MonoBehaviour
{

    private bool playerInZone;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDwon())
    //}

    void OnTriggerEnter(Collider2D other)
    {
        if (other.name == "Hero")
        {
            playerInZone = true;
        }
    }
}
