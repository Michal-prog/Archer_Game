using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Timeline;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator myAnimation;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            myAnimation.SetBool("Shoot", true);
        }
    }
}


