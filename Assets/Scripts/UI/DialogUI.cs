using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{

    public static DialogUI Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    
    public GameObject[] dialogButton = new GameObject[4];
    
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private Image dialogImage;
    
    public void SetupDialog(string text, Sprite image)
    {
        dialogText.text = text;
        dialogImage.sprite = image;
        DisableDialogOption();
    }
    
    public void SetupDialogOption(DialogOption dialogOption)
    {
        /*dialogText.text = dialogOption.dialogOptionText;
        dialogImage.sprite = dialogOption.dialogOptionImage;
        
        for (int i = 0; i < dialogButton.Length; i++)
        {
            if (i < dialogOption.dialogOptions.Length)
            {
                dialogButton[i].SetActive(true);
                dialogButton[i].GetComponentInChildren<TextMeshProUGUI>().text = dialogOption.dialogOptions[i].optionText;
            }
            else
            {
                dialogButton[i].SetActive(false);
            }
        }*/
    }
    
    
    public void DisableDialogOption()
    {
        for (int i = 0; i < dialogButton.Length; i++)
        {
            dialogButton[i].SetActive(false);
        }
    }

    public void EndDialog()
    {
        gameObject.SetActive(false);
    }
}
