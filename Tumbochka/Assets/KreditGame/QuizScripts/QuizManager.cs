using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Linq; 

public class QuizManager : MonoBehaviour
{
    

    [Header("UI Элементы для вопроса")]
    public TextMeshProUGUI QuestionText; 
    public List<Button> AnswerButtons; 
    public TextMeshProUGUI ProgressText;



    [Header("Управление логикой")]
    private List<string> userAnswers = new List<string>();
    private int currentQuestionIndex = 0;
    private List<QuizQuestion> shuffledQuestions; 


    
    [Header("UI Элементы для результатов")]
    public GameObject QuizPanel;
    public GameObject ResultsPanel;
    public TextMeshProUGUI FinalScoreText;
    public GameObject FonResult;

   
    void Start()
    {
      
        shuffledQuestions = QuizData.Questions.OrderBy(_ => Random.value).ToList();


        for (int i = 0; i < AnswerButtons.Count; i++)
        {

            int buttonIndex = i; 
      
            // AnswerButtons[i].onClick.AddListener(() => AnswerSelected(buttonIndex));
        }
        
     
        QuizPanel.SetActive(true);
        ResultsPanel.SetActive(false);
        
        DisplayQuestion(currentQuestionIndex);
    }
    

 
    private void DisplayQuestion(int index)
    {
        if (index >= shuffledQuestions.Count || index < 0) return; 

        QuizQuestion currentQuestion = shuffledQuestions[index];
        
    
        QuestionText.text = currentQuestion.Text;
        
   
        List<string> answers = currentQuestion.ShuffleAnswers(); 
        
   
        for (int i = 0; i < AnswerButtons.Count; i++)
        {
            if (i < answers.Count)
            {
   
                AnswerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = answers[i];
                AnswerButtons[i].gameObject.SetActive(true);
            }
            else
            {
                AnswerButtons[i].gameObject.SetActive(false); 
            }
        }
        
  
        ProgressText.text = $"Вопрос {index + 1} из {shuffledQuestions.Count}";
    }

    
    public void AnswerSelected(int buttonIndex)
    {
        
        string selectedAnswer = AnswerButtons[buttonIndex].GetComponentInChildren<TextMeshProUGUI>().text;
        
        
        userAnswers.Add(selectedAnswer);
        
        currentQuestionIndex++;
        
        if (currentQuestionIndex < shuffledQuestions.Count)
        {
            DisplayQuestion(currentQuestionIndex);
        }
        else
        {
            ShowResults();
        }
    }

   private void ShowResults()
    {
        FonResult.SetActive(true); 
        List<QuizSummaryItem> summary = QuizService.GenerateSummary(shuffledQuestions, userAnswers);
        int correctCount = summary.Count(item => item.IsCorrect);
        int totalQuestions = shuffledQuestions.Count;
        FinalScoreText.text = $"Викторина завершена!\nВы ответили правильно на {correctCount} из {totalQuestions} вопросов.";
        QuizPanel.SetActive(false);
        
    }
}