using System.Collections.Generic;
using System.Linq;


public static class QuizService
{
   
    public static List<QuizSummaryItem> GenerateSummary(List<QuizQuestion> questionsUsed, List<string> userAnswers)
    {
        
        var summaryItems = questionsUsed 
            
            .Take(userAnswers.Count) 
            .Select((question, index) => new QuizSummaryItem(
                index: index,
                text: question.Text,
                correct: question.CorrectAnswer, 
                selected: userAnswers[index]
            ))
            .ToList();

        return summaryItems;
    }
}