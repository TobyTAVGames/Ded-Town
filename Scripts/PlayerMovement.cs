using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;

    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _playerSprite;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private Vector2 _vectorMove;
    
    private void FixedUpdate()
    {
        _playerRigidbody.AddForce(_vectorMove * _speed);

        if(_vectorMove.x < 0) _playerSprite.flipX = true;
        else if(_vectorMove.x > 0) _playerSprite.flipX = false;
    }

    public void LeftDown()
    {
        _playerAnimator.SetBool("isMove", true);
        _vectorMove.x = -1;
    }

    public void LeftUp()
    {
        _playerAnimator.SetBool("isMove", false);
        _vectorMove.x = 0;
    }

    public void RightDown()
    {
        _playerAnimator.SetBool("isMove", true);
        _vectorMove.x = 1;
    }

    public void RightUp()
    {
        _playerAnimator.SetBool("isMove", false);
        _vectorMove.x = 0;
    }

    public void UpUp()
    {
        _playerAnimator.SetBool("isMove", false);
        _vectorMove.y = 0;
    }
    
    public void UpDown()
    {
        _playerAnimator.SetBool("isMove", true);
        _vectorMove.y = 1;
    }

    public void DownUp()
    {
        _playerAnimator.SetBool("isMove", false);
        _vectorMove.y = 0;
    }

    public void DownDown()
    {
        _playerAnimator.SetBool("isMove", true);
        _vectorMove.y = -1;
    }
}
