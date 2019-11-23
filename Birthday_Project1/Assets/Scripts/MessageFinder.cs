using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageFinder : MonoBehaviour
{
    public GameObject messageContainer;
    public Image _messageImage1;
    public Image _messageImage2;
    public Sprite defaultImage;
    public Text messageDisplayText;
    private Messages.MessagesArray[] _messages;
   
    // Start is called before the first frame update
    void Start()
    {
        _messages = messageContainer.GetComponent<Messages>().messages;
    }

    public void FindMessageFor(Button nameBut)
    {
        int index = -1;
        for (int i = 0; i < _messages.Length; i++)
        {
            if (_messages[i].name == nameBut.name)
                index = i;
        }

        if (index != -1)
        {
            messageDisplayText.text = _messages[index].message;

            if (_messages[index].image1 != null)
                _messageImage1.sprite = _messages[index].image1;
            else
                _messageImage1.sprite = defaultImage;
            if (_messages[index].image2!=null)
            _messageImage2.sprite = _messages[index].image2;
            else
                _messageImage2.sprite = defaultImage;
        }
        else
        {
            messageDisplayText.text = "No message Found for this person!";
            _messageImage1.sprite = null;
            _messageImage2.sprite = null;
        }

    }
}
