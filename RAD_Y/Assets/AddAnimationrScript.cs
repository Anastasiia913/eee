using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AddAnimationrScript : MonoBehaviour

{
    Animator edAnimator;
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        edAnimator.SetBool("IsRunning", false);

        {

            if (Input.GetKey(KeyCode.W))

                edAnimator.SetBool("IsRunning", true);
            transform.position += speed * transform.forward * Time.deltaTime;
        }
    }
}
