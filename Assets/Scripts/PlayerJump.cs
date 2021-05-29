using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public AnimationCurve jumpCurve;

    private bool _isJumping;
    private float _startingJumpHeight;
    private float _jumpTime = 0.0f;

    void Update()
    {
        if (_isJumping)
        {
            _jumpTime += Time.deltaTime;
            Vector3 position = transform.position;

            if (_jumpTime > 1.0f)
            {
                _isJumping = false;
                _jumpTime = 0.0f;
                position.y = _startingJumpHeight;
                transform.position = position;
            }
            else
            {
                position.y = _startingJumpHeight + jumpCurve.Evaluate(_jumpTime);
                transform.position = position;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
        {
            _isJumping = true;
            _startingJumpHeight = transform.position.y;
        }
    }
}
