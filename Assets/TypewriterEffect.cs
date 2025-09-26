    using System.Collections;
    using UnityEngine;
    using TMPro; // Не забудьте добавить это пространство имен

    public class TypewriterEffect : MonoBehaviour
    {
        public TextMeshProUGUI textMesh;
        public string fullText;
        public float delay = 0.1f; // Задержка в секундах

        void Start()
        {
            StartCoroutine(ShowTextByLetters());
        }

        IEnumerator ShowTextByLetters(string test)
        {
            fullText = test;
            textMesh.text = ""; // Очищаем текст перед началом
            foreach (char letter in fullText)
            {
                textMesh.text += letter; // Добавляем следующую букву
                yield return new WaitForSeconds(delay); // Ждем заданное время
            }

        }
    }