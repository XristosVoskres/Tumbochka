using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonOnTumbaTheme : MonoBehaviour
{

    
    public Animator animPanel_Theme;

    public Animator camAnim_Theme;

    
    public void ButtonStart()
    {
    
        camAnim_Theme.SetBool("selFirst", true);
        animPanel_Theme.SetBool("closePanel", true);
        Invoke("CallMethodSwapScene", 2f);

    }

    public void ButtonSeting()
    {
        camAnim_Theme.SetBool("selSecond", true);
        animPanel_Theme.SetBool("closePanel", true);
        
    }

    public void ButtonExit()
    {
        camAnim_Theme.SetBool("selThird", true);
        animPanel_Theme.SetBool("closePanel", true);
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
