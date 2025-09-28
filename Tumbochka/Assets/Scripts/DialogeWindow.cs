using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class DialogeWindow : Sounds
{
    public GameObject DialogWindow;
    public TextMeshProUGUI DialogText;
    public float delay = 1000f;
    public GameObject DialogVariants;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public Slider slider;

    private int currentLine = 0;
    private bool isTyping = false;
    private Coroutine typingCoroutine;
    private List<string> dialogLines = new List<string>
    {
        "",
        "Здравствуйте. С какой целью берёте кредит?",
        "Каков ваш текущий официальный доход?",
        "Подтверждающие документы имеются?",
        "Конец диалога."
    };

    void Start()
    {
        //DialogWindow.SetActive(false);
        //DialogVariants.SetActive(false);
    }


    void Update()
    {
        switch (currentLine)
        {
            case 1:
                Text1.text = "Покупка машины Tesla";
                Text2.text = "Покупка машины Жигули";
                Text3.text = "Додеп в казик";
                break;
            case 2:
                Text1.text = "Около 40-45 тысяч.";
                Text2.text = "Официально 45, но с премиями стабильно 70+";
                Text3.text = "Стабильно 95 тысяч.";
                break;
            case 3:
                Text1.text = "Есть выписка с расчетного счета за полгода";
                Text2.text = "Да, справка 2-НДФЛ.";
                Text3.text = "Нет, к сожалению.";
                break;
            case 4:
                Text1.text = "";
                Text2.text = "";
                Text3.text = "";
                break;
            case 5 :
                Text1.text = "";
                Text2.text = "";
                Text3.text = "";
                break;



        }

        if (!isTyping) StopSound();
        if (Input.GetKeyDown(KeyCode.S)) StopSound();
        
    }
    public void Button()
    {
        if (!DialogWindow.activeSelf)
        {
            StartDialog();
        }
        else
        {
            if (isTyping)
            {
                StopCoroutine(typingCoroutine);
                DialogText.text = dialogLines[currentLine];
                isTyping = false;
            }
            else
            {
                StopSound();
                ShowNextLine();
            }
        }
    }
    void StartDialog()
    {
        DialogWindow.SetActive(true);
        currentLine = 0;
        typingCoroutine = StartCoroutine(TypeText(dialogLines[currentLine]));
    }

    void ShowNextLine()
    {
        currentLine++;
        if (currentLine < dialogLines.Count)
        {
            typingCoroutine = StartCoroutine(TypeText(dialogLines[currentLine]));
        }
        else
        {
            DialogWindow.SetActive(false);
        }
    }

    IEnumerator TypeText(string text)
    {
        isTyping = true;
        DialogText.text = "";
        PlaySound(sounds[0]);
        foreach (char letter in text)
        {
            DialogText.text += letter;
            yield return new WaitForSeconds(delay);
        }

        isTyping = false;
    }
    
    public void Button1Func()
    {
        slider.value -=0.2f;
    }
    public void Button2Func()
    {
        slider.value +=0.1f;
    }
    public void Button3Func()
    {
        slider.value +=0.2f;
    }

}