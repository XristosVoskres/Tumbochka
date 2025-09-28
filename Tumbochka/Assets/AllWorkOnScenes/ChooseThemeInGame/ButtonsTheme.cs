using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsTheme : MonoBehaviour
{

    public GameObject panel;
    public Animator animPanel_Theme;

    public Animator camAnim_Theme;
    void Start()
    {
        Invoke("CanclePanel", 1f);
    }

    public void ButtonStart()
    {
         panel.transform.localScale = new Vector3(1.1924501f, 1.1924501f, 1.1924501f);
        camAnim_Theme.SetBool("selFirst", true);
        animPanel_Theme.SetBool("closePanel", true);
        Invoke("CallMethodSwapScene", 2f);

    }

    public void ButtonSeting()
    {
        panel.transform.localScale = new Vector3(1.1924501f, 1.1924501f, 1.1924501f);
        camAnim_Theme.SetBool("selSecond", true);
        animPanel_Theme.SetBool("closePanel", true);
        Invoke("CallMethodSeting", 2f);

    }

    public void ButtonExit()
    {
        panel.transform.localScale = new Vector3(1.1924501f, 1.1924501f, 1.1924501f);
        camAnim_Theme.SetBool("selThird", true);
        animPanel_Theme.SetBool("closePanel", true);
        Invoke("CallMethodQuit", 2f);
    }

    public void CallMethodSwapScene()
    {
        SceneManager.LoadScene("Scenes/KreditGame");
    }
    public void CallMethodQuit()
    {
        //Тут будет донатная часть
    }
    public void CallMethodSeting()
    {
        // SceneManager.LoadScene("Scenes/"); Тоже донатная часть
    }
    void CanclePanel()
    {
        panel.transform.localScale = new Vector3(0f, 0f, 0f);
    }
}
