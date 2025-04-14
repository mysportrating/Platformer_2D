using UnityEngine;

public class InputReader : MonoBehaviour
{
    private bool _isJump;

    public float Direction { get; private set; }

    private void Update()
    {
        Direction = Input.GetAxis(ConstantsData.InputData.HORIZONTAL_AXIS);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJump = true;
        }
    }

    public bool GetIsJump ()
    {
        bool isJump = _isJump;
        _isJump = false;
        return isJump;
    }
}
