using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    [SerializeField] private Animator _animator;

    public void SetSpeedX(float speedX)
    {
        _animator.SetFloat(ConstantsData.AnimatorParameters.SpeedX, Mathf.Abs(speedX));
    }

    public void ActivatePlayJump() => PlayJump(true);

    public void DeactivatePlayJump() => PlayJump(false);

    private void PlayJump(bool playJumpIsActive)
    {
        _animator.SetBool(ConstantsData.AnimatorParameters.Jump, playJumpIsActive);
    }
}