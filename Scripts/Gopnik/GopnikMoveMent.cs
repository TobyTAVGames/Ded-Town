using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopnikMoveMent : MonoBehaviour
{
    [Header("Gopnik Settings")]
    [SerializeField] private GameObject _gopnik;

    [SerializeField] private Animator _gopnikAnimator;
    [SerializeField] private Rigidbody2D _gopnikRigidbody;
    [SerializeField] private float _gopnikSpeed;
    [SerializeField] private float _agressivDistance = 7f;

    [Header("Other Settings")]
    [SerializeField] private GameObject _player;
    private float _distanceOfPlayerToGopnik;
 
    private void FixedUpdate()
    {
        _distanceOfPlayerToGopnik = Vector2.Distance(_player.transform.position, _gopnik.transform.position);

        if(_distanceOfPlayerToGopnik <= _agressivDistance)
        {
            StartHunting();
        }

        else
        {
            _gopnikRigidbody.velocity = new Vector2(0, 0);
        }
    }

    private void StartHunting()
    {
  
        if(_player.transform.position.x > _gopnik.transform.position.x && _player.transform.position.y > _gopnik.transform.position.y)
        {
            _gopnikRigidbody.velocity = new Vector2(_gopnikSpeed, _gopnikSpeed);
        }

        else
        {
            _gopnikRigidbody.velocity = new Vector2(-_gopnikSpeed, 0);
        }

        if(_player.transform.position.y > _gopnik.transform.position.y && _player.transform.position.x > _gopnik.transform.position.x)
        {
            _gopnikRigidbody.velocity = new Vector2(_gopnikSpeed, _gopnikSpeed);
        }

        else
        {
            _gopnikRigidbody.velocity = new Vector2(0, -_gopnikSpeed);
        }
    }
}
