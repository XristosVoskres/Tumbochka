using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class FindObjectByID : MonoBehaviour
{
    public int objectID = 23456;

    void Start()
    {
        // Этот код будет выполняться только в редакторе
#if UNITY_EDITOR
        if (objectID != 0)
        {
            Object foundObject = EditorUtility.InstanceIDToObject(objectID);

            if (foundObject != null)
            {
                Debug.Log("Found object: " + foundObject.name);
                // Если нужно выделить объект в Иерархии
                // Selection.activeObject = foundObject;
            }
            else
            {
                Debug.LogWarning("Object with ID " + objectID + " not found.");
            }
        }
#endif
    }
}