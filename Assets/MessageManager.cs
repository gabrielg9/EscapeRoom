using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{
    public Mobile_out mobilePressedButton;
    public string username;

    public int maxMessages = 25;

    public GameObject chatPanel, textObject;
    public InputField chatBox;

    public Color playerMessage, replyMessage, info;

    [SerializeField]
    List<Message> messageList = new List<Message>();

    void Start()
    {
        
    }

    void Update()
    {
        if(mobilePressedButton.pressButton)
        {
            if (chatBox.text != "")
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (chatBox.text == "studiowanie2019")
                    {
                        SendMessageToChat(username + ": " + chatBox.text, Message.MessageType.info);
                        chatBox.text = "";
                        SendMessageToChat("AGH założono w 1919 roku.", Message.MessageType.replyMessage);
                    }
                    else
                    {
                        SendMessageToChat(username + ": " + chatBox.text, Message.MessageType.playerMessage);
                        chatBox.text = "";
                        SendMessageToChat("Wiadomość niepoprawna, podaj hasło krzyżówki", Message.MessageType.replyMessage);
                    }
                }
            }
            else
            {
                if (!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return))
                    chatBox.ActivateInputField();
            }

            if (!chatBox.isFocused)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SendMessageToChat("Nacisnąłeś spację", Message.MessageType.info);
                    Debug.Log("Space");
                }
            }
        }
    }

    public void SendMessageToChat(string text, Message.MessageType messageType)
    {
        if (messageList.Count >= maxMessages)
        {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        
        Message newMessage = new Message();
        newMessage.text = text;
        GameObject newText = Instantiate(textObject, chatPanel.transform);
        newMessage.textObject = newText.GetComponent<Text>();
        newMessage.textObject.text = newMessage.text;

        if(messageType == Message.MessageType.replyMessage)
            newMessage.textObject.alignment = TextAnchor.UpperLeft;

        newMessage.textObject.color = MessageTypeColor(messageType);

        messageList.Add(newMessage);
    }

    Color MessageTypeColor(Message.MessageType messageType)
    {
        Color color = info;

        switch(messageType)
        {
            case Message.MessageType.playerMessage:
                color = playerMessage;
                break;
            case Message.MessageType.replyMessage:
                color = replyMessage;
                break;
        }
        return color;
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
    public MessageType messageType;

    public enum MessageType
    {
        playerMessage,
        replyMessage,
        info
    }
}
