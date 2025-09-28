using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject DialogWindow;
    public void Swap()
    {
        button.SetActive(false);
        DialogWindow.SetActive(true);
        Debug.Log("Кнопка Нажата");
    }
}
