using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RayInCamera : ButtonsTheme
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


