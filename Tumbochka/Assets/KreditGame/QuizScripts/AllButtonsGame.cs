using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// using TMPro;

public class AllButtonsGame : MonoBehaviour
{
  
    public GameObject panel;
    public Animator animPanel;
    public GameObject downPanel;
    public Animator ticket;
    // public TextMeshProUGUI downText;
    void Start()
    {
       Invoke("DropPanel", 0.8f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonFalse()
    {

        downPanel.SetActive(true);
        Invoke("ClosePanel", 5f);
    }
    public void ButtonTrue()
    {
        ticket.SetBool("selKredit", true);

    }
    void ClosePanel()
    {
        downPanel.SetActive(false);
    }
    public void LoadScene()
    {
        panel.transform.localScale = new Vector3(0.1924501f, 0.1924501f, 0.1924501f);
        animPanel.SetBool("closePanel", true);
        Invoke("CallMethodLoadScene", 1.2f);

    }
    void CallMethodLoadScene()
    {
        SceneManager.LoadScene("QuizScene");
    }
    public void DropPanel()
    {
        panel.transform.localScale = new Vector3(0, 0, 0);
    } 

}
