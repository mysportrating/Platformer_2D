using UnityEngine;

[RequireComponent (typeof(InputReader), typeof(GroundDetector), typeof(PlayerMover))]
[RequireComponent (typeof(PlayerAnimator))]

public class Player : MonoBehaviour
{
    private PlayerMover _mover;
    private InputReader _inputReader;
    private GroundDetector _groundDetector;
    private PlayerAnimator _playerAnimator;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _groundDetector = GetComponent<GroundDetector>();
        _mover = GetComponent<PlayerMover>();
        _playerAnimator = GetComponent<PlayerAnimator>();
    }

    private void FixedUpdate()
    {
        _playerAnimator.SetSpeedX(_inputReader.Direction);

        if (_inputReader.Direction != 0)
            _mover.Move(_inputReader.Direction);

        if (_inputReader.GetIsJump() && _groundDetector.IsGround)
            _mover.Jump();
    }
}