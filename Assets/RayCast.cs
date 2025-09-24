using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFromCursor : MonoBehaviour
{
    public float rayCastDistance = 100f;
    Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Animator animator = hit.collider.GetComponent<Animator>();
                
                // Проверяем, что компонент Animator существует
                if (animator != null)
                {
                    // Устанавливаем булевую переменную "IsHit" в true
                    animator.SetBool("", true);
                }
            }
        }

