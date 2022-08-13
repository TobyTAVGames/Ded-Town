using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private Data[] _data;

    [Header("UI Elements")]
    [SerializeField] private GameObject _dialogueCanvas;
    [SerializeField] private GameObject[] _playerAnswerButtons;
    [SerializeField] private Text[] _playerAnswerText;
    [SerializeField] private Text _personTextCanvas;
    
    private void Start()
    {
        _personTextCanvas.text = _data[0]._personText;
        for (int i = 0; i < _playerAnswerText.Length; i++)
        {
            _playerAnswerText[i].text = _data[0]._playerAnswer;
        }
    }


    public void FirstButton()
    {
        //
    }

    public void SecondButton()
    {
        //
    }

    public void ThirdButton()
    {
        //
    }

}



[System.Serializable]
public class Data
{
    public string _personText;
    public string _playerAnswer;

    public int _selectNode;

    public bool _anyMove;
    public bool _endOfDialogue;
}

