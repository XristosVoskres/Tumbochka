using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Raycast : ButtonOnTumba
{

    public GameObject firstPolka_theme;
    public Animator firstAnimPolka_theme;

    public GameObject secondPolka_theme;
    public Animator secondAnimPolka_theme;

    public GameObject thirdPolka_theme;
    public Animator thirdAnimPolka_theme;

    public float rayCastDistance_theme = 1000f;
    Camera mainCamera_theme;

    void Awake()
    {
        // mainCamera = Camera.main;        
        mainCamera_theme = GetComponent<Camera>();

    }


    void Update()
    {
        Ray ray = mainCamera_theme.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayCastDistance_theme))
        {
            if (hit.collider.gameObject.tag == "polka1")
            {
                firstAnimPolka_theme.SetBool("inBox", true);
            }
            else
            {
                firstAnimPolka_theme.SetBool("inBox", false);
            }

            if (hit.collider.gameObject.tag == "polka2")
            {
                secondAnimPolka_theme.SetBool("inBox2", true);
            }
            else
            {
                secondAnimPolka_theme.SetBool("inBox2", false);
            }

            if (hit.collider.gameObject.tag == "polka3")
            {
                thirdAnimPolka_theme.SetBool("inBox3", true);
            }
            else
            {
                thirdAnimPolka_theme.SetBool("inBox3", false);
            }
        }
    }

  
        
}


