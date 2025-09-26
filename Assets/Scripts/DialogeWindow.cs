using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogeWindow : MonoBehaviour
{
    public GameObject DialogWindow;
    public TextMeshProUGUI DialogText; // Drag сюда компонент Text из Canvas

    private List<string> dialogLines = new List<string>
    {
        "Привет! Это первая реплика.",
        "А вот и вторая строка диалога.",
        "Конец диалога."
    };

    private int currentLine = 0;

    void Start()
    {
        DialogWindow.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!DialogWindow.activeSelf)
            {
                DialogWindow.SetActive(true);
                currentLine = 0;
                DialogText.text = dialogLines[currentLine];
            }
            else
            {
                currentLine++;
                if (currentLine < dialogLines.Count)
                {
                    DialogText.text = dialogLines[currentLine];
                }
                else
                {
                    DialogWindow.SetActive(false);
                }
            }
        }
    }
}
// class DataQuiz 
// {
//   const DataQuiz(this.text, this.answers);

//   final String text;
//   final List<String> answers;

//   List<String> shuffleArr(){
//     final shuffleArr = List.of(answers);
//     shuffleArr.shuffle();
//     return shuffleArr;
//   }
// }

// const questions = 
// [
//   DataQuiz('Кто такая Настя', [
//     'Истеричка',
//     'Псих',
//     'Настя молодец так как я ее люблю',
//   ]),
//   DataQuiz('Какой у меня ранг в калоранте', [
//     '3 сильвер',
//     '2 сильвер',
//     'в душе радиант',
//   ]),
//   DataQuiz('Все, заебал со своими вопросами', [
//     'иди нахуй',
//     'сам иди нахуй',
//     'а может вы все здесь пойдете нахуй',
//   ]),
// ];
