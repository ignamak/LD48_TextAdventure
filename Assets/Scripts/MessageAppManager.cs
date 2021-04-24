using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageAppManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI aiName;
    [SerializeField] TextMeshProUGUI aiMessage;
    [SerializeField] TextMeshProUGUI playerAnswer;

    public Dropdown dropdown;

    public GameObject aiMessagePrefab;
    public GameObject playerAnswerPrefab;
    private GameObject playerMes;
    public GameObject messagePlaceHolder;


    int aiNumber = 0;
    int optionChosenValue;

    public int numberOfMessages = 0;

    public list[] ListOfAIS;

    public AImessage currentMessage;

    
    // Start is called before the first frame update
    void Start()
    {
        OpenConversation();

        dropdown.onValueChanged.AddListener(
            delegate 
            { 
                GetDropdownValue(dropdown); 
            });
    }

    // Update is called once per frame
    void Update()
    {
        aiName.text = currentMessage.aiName;
        aiMessage.text = currentMessage.messageText;
    }
    private void OpenConversation()
    {
        List<string> options = new List<string>();
        
        dropdown.ClearOptions();

        foreach (var option in currentMessage.playerAnswers)
        {
            options.Add(option.answer);
        }
        dropdown.AddOptions(options);

    }
    public void newPlayerMessage()
    {
        playerAnswerPrefab.GetComponentInChildren<TextMeshProUGUI>().text = currentMessage.playerAnswers[optionChosenValue].answer;
        playerMes = Instantiate(playerAnswerPrefab);
        playerMes.transform.SetParent(messagePlaceHolder.transform);
    }
    public void GetDropdownValue(Dropdown sender)
    {
        optionChosenValue = sender.value;
        Debug.Log("You have chosen: " + sender.value);
    }
}
[System.Serializable]
public class list
{
    public List <AImessage> aiMessagesList = new List<AImessage>();

}
