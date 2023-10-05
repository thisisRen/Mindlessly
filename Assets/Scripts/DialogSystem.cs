using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : Singleton<DialogSystem>
{
    [SerializeField] private DialogData dialogData;
    [SerializeField] private DialogOptionData dialogOptionData;
    
    
    private Dialog currentDialog;
    private int currentLine; 
    
    
    public void StartDialog(int dialogId)
    {
        currentDialog = dialogData.GetDialog(dialogId);
        currentLine = 0; 
        if (currentDialog is null)
        {
            Debug.LogError("Dialog not found");
            return;
        }
        DialogUI.Instance.SetupDialog(currentDialog.dialogLines[currentLine], currentDialog.dialogImage);
    }

    
    public void StartDialogOption(DialogOption dialogOption)
    {
        
    }
    
    public void EndDialog()
    {
        DialogUI.Instance.EndDialog();
    }
    
    public void EndDialogOption()
    {
       
    }
    
    public void NextDialog()
    {
        currentLine++;
        if (currentLine >= currentDialog.dialogLines.Count)
        {
            EndDialog();
            return;
        }
        DialogUI.Instance.SetupDialog(currentDialog.dialogLines[currentLine], currentDialog.dialogImage);
    }
    
    public void NextDialogOption()
    {
       
    }
    
    
    

    

}
