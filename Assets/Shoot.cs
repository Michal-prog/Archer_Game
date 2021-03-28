using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void ArrowMove()
    {
        var maxSpeed = 3;

        GetComponent<Rigidbody2D>().AddForce( new Vector2(200 * maxSpeed, 150));
    }
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }
// Update is called once per frame
void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().simulated = true;
            ArrowMove();
        }
    }
}
