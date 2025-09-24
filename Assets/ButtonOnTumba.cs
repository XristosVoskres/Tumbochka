using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonOnTumba : Raycast
{

    public Animator camAnim;

    void Update()
    {

    }
    public void ButtonStart()
    {

        camAnim.SetInteger("selButton", 1);
        Invoke("CallMethodSwapScene", 1f);

    }

    public void ButtonSeting()
    {
        camAnim.SetInteger("selButton", 2);
    }

    public void ButtonExit()
    {
        camAnim.SetInteger("selButton", 3);
        Invoke("CallMethodQuit", 1f);
    }

    public void CallMethodQuit()
    {
        Application.Quit();
    }

    public void CallMethodSwapScene()
    {
        SceneManager.LoadScene("Scenes/Game");
    }
}
