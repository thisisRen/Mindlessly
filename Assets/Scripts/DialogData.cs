using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "DialogData", menuName = "DialogData", order = 0)]
public class DialogData : ScriptableObject
{
    [InfoBox("Nhấn vào nút Update Data để cập nhật lại ID cho các dialog")]
    
    [Button("Update Data")]
    public void AddDialog()
    {
        for (int i = 0; i < dialogs.Count; i++)
            dialogs[i].id = i + 1;
    }

    public List<Dialog> dialogs;

    public Dialog GetDialog(int id)
    {
        return dialogs.Find(x => x.id == id);
    }
}

[CreateAssetMenu(fileName = "DialogOptionData", menuName = "DialogOptionData", order = 1)]
public class DialogOptionData : ScriptableObject
{
    [InfoBox("Nhấn vào nút Update Data để cập nhật lại ID cho các dialog")]
    
    [Button("Update Data")]
    public void AddDialog()
    {
        for (int i = 0; i < dialogOptions.Count; i++)
            dialogOptions[i].id = i + 1;
    }

    public List<DialogOption> dialogOptions;
    
    public DialogOption GetDialogOption(int id)
    {
        return dialogOptions.Find(x => x.id == id);
    }
}


[System.Serializable]
public class DialogOption
{
    [GUIColor(1, 0, 0), ReadOnly] public int id;
    public string questText; 
    public Option[] options = new Option[4];
}


[System.Serializable]
public class Option
{
    [LabelText("Option Text")] public string optionText;
    [LabelText("Next Dialog ID")] public int nextDialogId;
}

[System.Serializable]
public class Dialog
{
    [HorizontalGroup("Split", 0.5f)] [PreviewField(50)]
    public Sprite dialogImage;

    [GUIColor(1, 0, 0), ReadOnly] public int id;
    public List<string> dialogLines;
}