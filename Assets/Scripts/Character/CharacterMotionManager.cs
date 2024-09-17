using UnityEngine;

public class CharacterMotionManager : MonoBehaviour
{  
    private CharacterManager characterManager;
    private Vector3 movementDirection;
    private float horizontalMovement;
    private float verticalMovement;
    private void Awake()
    {
        characterManager = GetComponent<CharacterManager>();
    }
    public void HandleAllMovement()
    {
        HandleGroundMovement();
    }
    private void GetValueMovementInput()
    {
        horizontalMovement = CharacterInputManager.instance.HorizontalMovement;
        verticalMovement = CharacterInputManager.instance.VerticalMovement;
    }
    private void HandleGroundMovement()
    {
        GetValueMovementInput();
        movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);

        characterManager.CharacterController.Move(movementDirection * Time.deltaTime);
    }

    
}
