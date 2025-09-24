using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{

    public GameObject firstPolka;
    public Animator firstAnimPolka;

    public GameObject secondPolka;
    public Animator secondAnimPolka;

    public GameObject thirdPolka;
    public Animator thirdAnimPolka;

    public float rayCastDistance = 1000f;
    Camera mainCamera;

    void Awake()
    {
        // mainCamera = Camera.main;        
        mainCamera = GetComponent<Camera>();

    }

    void Start()
    {
        
    }
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayCastDistance))
        {
            if (hit.collider.gameObject.tag == "polka1")
            {
                firstAnimPolka.SetBool("inBox", true);
            }
            else
            {
                firstAnimPolka.SetBool("inBox", false);
            }

            if (hit.collider.gameObject.tag == "polka2")
            {
                secondAnimPolka.SetBool("inBox2", true);
            }
            else
            {
                secondAnimPolka.SetBool("inBox2", false);
            }

             if (hit.collider.gameObject.tag == "polka3")
            {
                thirdAnimPolka.SetBool("inBox3", true);
            }
            else
            {
                thirdAnimPolka.SetBool("inBox3", false);
            }
        }
    }
    
    
}

    
    // if (startTime <= 1)
                // {
                //     boolTime = true;
                //     startTime += Time.deltaTime;
                //     firstPolka.transform.position = new Vector3(transform.position.x + startTime, 0.6666666f, transform.position.z);
                // }
                // else{firstPolka.transform.position = new Vector3(startTime, 0.6666666f, transform.position.z);}

                // firstPolka.position = new Vector3()

    // void Moving () {
        
    // }
    
            // Animator animator = hit.collider.GetComponent<Animator>();

            // If the hit object has an Animator and its collider is a trigger...
            // if (animator != null && hit.collider.isTrigger)
            // {
            //     // ...set the boolean parameter in the Animator to true.
            //     animator.SetBool("inColider", true);
            // }


