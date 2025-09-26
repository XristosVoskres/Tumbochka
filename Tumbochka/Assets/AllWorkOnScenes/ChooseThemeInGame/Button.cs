using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonOnTumba : MonoBehaviour
{

    
    public Animator animPanel;

    public Animator camAnim;

    
    public void ButtonStart()
    {
    
        camAnim.SetBool("selFirst", true);
        animPanel.SetBool("closePanel", true);
        Invoke("CallMethodSwapScene", 2f);

    }

    public void ButtonSeting()
    {
        camAnim.SetBool("selSecond", true);
        animPanel.SetBool("closePanel", true);
        
    }

    public void ButtonExit()
    {
        camAnim.SetBool("selThird", true);
        animPanel.SetBool("closePanel", true);
        Invoke("CallMethodQuit", 2f);
    }

    public void CallMethodQuit()
    {
        Application.Quit();
    }

    public void CallMethodSwapScene()
    {
        SceneManager.LoadScene("Scenes/ChooseTheme");
    }
}
