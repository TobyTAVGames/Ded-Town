using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavkaMechanic : MonoBehaviour
{

    [Header("UI Settings")]
    [SerializeField] private GameObject _upButton;
    [SerializeField] private GameObject _downButton;

    [Header("Sitting Settings")]
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _moveButtons;
    [SerializeField] private GameObject _lavkaSitPosition;

    public void Sitting()
    {
        transform.position = _lavkaSitPosition.transform.position;
        _player.transform.SetParent(_lavkaSitPosition.transform);
        _moveButtons.SetActive(false);
        _downButton.SetActive(false);
        _upButton.SetActive(true);
    }

    public void Standing()
    {
        _player.transform.SetParent(null);
        _moveButtons.SetActive(true);
        _upButton.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Lavka")
        {
            _downButton.SetActive(true);
            _lavkaSitPosition = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Lavka")
        {
            _downButton.SetActive(false);
            _lavkaSitPosition = null;
        }
    }
}
