using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactManager : MonoBehaviour
{
    public InputField inputField;
    public GameObject emptyConversation;
    public GameObject aiConversation1;

    public GameObject ai1Contact;

    public int ai1Number = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenConversation()
    {
        if (aiConversation1)
        {
            emptyConversation.SetActive(false);
        }
        aiConversation1.SetActive(true);
    }
    public void CheckNumber()
    {
        
        if (int.Parse(inputField.text) == ai1Number)
        {
            ai1Contact.SetActive(true);
            Debug.Log("contact active");
        }
    }
}
