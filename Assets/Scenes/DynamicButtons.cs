using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class DynamicButtons : MonoBehaviour
{
    public GameObject dialogButtonPrefab;
    public GameObject dialogButtonParent;

    private void Start()
    {
        ButtonCreation(10);
    }

    // TODO -- Only make the buttons return integers depending on what button is press (e.g. button 0 will only return 0 when clicked).
    void ButtonCreation(int buttonCount) 
    {
        for (int i = 0; i < buttonCount; i++)
        {
            GameObject newDialogButton = Instantiate(dialogButtonPrefab, dialogButtonParent.transform);
            //newbutton.GetComponent<Button>().onClick.AddListener(() =>)
        }
    }

    private void DialogSelector()
    {
        Debug.Log("Working");
    }
}
