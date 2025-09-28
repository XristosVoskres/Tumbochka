using System;
using System.Collections.Generic;
using System.Linq;


public record QuizQuestion 
{
    public string Text { get; }
    public List<string> Answers { get; }


    public string CorrectAnswer => Answers.Count > 1 ? Answers[2] : string.Empty;

    public QuizQuestion(string text, List<string> answers)
    {
        Text = text;
        Answers = answers;
    }


    public List<string> ShuffleAnswers()
    {
        var shuffledList = new List<string>(Answers);
        Random rng = new Random();
        return shuffledList.OrderBy(_ => rng.Next()).ToList();
    }
}


public record QuizSummaryItem
{
    public int QuestionIndex { get; }
    public string QuestionText { get; }
    public string CorrectAnswer { get; }
    public string SelectedAnswer { get; }
    
  
    public bool IsCorrect => SelectedAnswer == CorrectAnswer;

    public QuizSummaryItem(int index, string text, string correct, string selected)
    {
        QuestionIndex = index;
        QuestionText = text;
        CorrectAnswer = correct;
        SelectedAnswer = selected;
    }
}



public static class QuizData
{
    public static readonly List<QuizQuestion> Questions = new List<QuizQuestion>
    {
      


        new QuizQuestion("Что такое «полная стоимость кредита» (ПСК)?", new List<string>
        {
            "Процентная ставка по кредиту",
            "Сумма, которую банк готов вам одолжить",
            "Сумма всех переплат по кредиту, включая проценты и все дополнительные комиссии.", 
        }),
        new QuizQuestion("Когда выгоднее всего брать кредит?", new List<string>
        {
            "Когда срочно нужны деньги на распродаже",
            "Когда банк предлагает «последний шанс» получить одобрение",
            "Когда есть четкий финансовый план и возможность его погашать.", 
        }),
        new QuizQuestion("Что важнее при выборе кредита?", new List<string>
        {
            "Минимальный ежемесячный платеж",
            "Минимальная процентная ставка",
            "Минимальная полная стоимость кредита (ПСК).", 
        }),
        new QuizQuestion("Что такое кредитная история?", new List<string>
        {
            "Список всех ваших долгов перед банками",
            "История работы банка с физическими лицами",
            "Досье о вашей платежной дисциплине по всем кредитам.", 
        }),
        new QuizQuestion("Какой ежемесячный платеж по кредиту считается комфортным?", new List<string>
        {
            "Не более 10% от дохода",
            "Не более 50% от дохода",
            "Не более 30-35% от дохода.", 
        }),
        new QuizQuestion("Что выгоднее: погасить кредит досрочно или копить деньги на депозите?", new List<string>
        {
            "Всегда выгоднее гасить кредит",
            "Всегда выгоднее копить на депозите",
            "Зависит от разницы между ставкой по кредиту и по вкладу.", 
        }),
        new QuizQuestion("Что такое «рефинансирование кредита»?", new List<string>
        {
            "Взять новый кредит, чтобы погасить старый по более высокой ставке",
            "Взять кредит для своих родственников",
            "Взять новый кредит на лучших условиях, чтобы погасить старые.", 
        }),
    };
}