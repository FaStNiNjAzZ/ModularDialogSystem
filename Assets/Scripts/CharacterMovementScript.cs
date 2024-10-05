using UnityEngine;
using static ControlScript;

public class CharacterMovemmentScript : MonoBehaviour
{
    ControlScript controlScript;

    #region "Variables"
    public Rigidbody Rigid;
    float MouseSensitivity = 1f;
    float MoveSpeed = 0.25f;
    float JumpForce = 1f;
    #endregion

    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    private void Start()
    {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    void Update()
    {
        

        CharacterMovement();
        CameraControl();

    }

    void CharacterMovement()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        if (Input.GetKeyDown("space"))
            Rigid.AddForce(transform.up * JumpForce);
    }

    void CameraControl()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C Pressed");
            if (firstPersonCamera.enabled == true) 
            { 
                firstPersonCamera.enabled = false;
                thirdPersonCamera.enabled = true;
            }

            else if (thirdPersonCamera.enabled == true)
            {
                thirdPersonCamera.enabled = false;
                firstPersonCamera.enabled = true;
            }
        }
    }
}