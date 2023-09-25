using UnityEngine;

// Include the namespace required to use Unity Input System
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {

    // At the start of the game..
    void Start ()
    {
    
    }

    void OnMove(InputValue moveVal)
    {
        Vector2 moveDir = moveVal.Get<Vector2>();

        Debug.Log(moveDir);
    }

    void OnFire()
    {
        Debug.Log("Fire!");
    }

    void OnJump()
    {
        Debug.Log("Jump!");
    }
}