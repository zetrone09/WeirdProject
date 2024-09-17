using UnityEngine;

public class CharacterInputManager : MonoBehaviour
{
    public static CharacterInputManager instance;

    private CharacterControl characterInput;

    private Vector2 movementInput;
    public float HorizontalMovement;
    public float VerticalMovement;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
        if (characterInput == null)
        {
            characterInput = new CharacterControl();

            characterInput.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
    }
    private void OnEnable()
    {     
        characterInput.Enable();
    }
    private void OnDisable()
    {
        characterInput.Disable();
    }
    private void Update()
    {
        HandleAllInput();
    }
    private void HandleAllInput()
    {
        HandleGroundMovement();
    }
    private void HandleGroundMovement()
    {
        HorizontalMovement = movementInput.x;
        VerticalMovement = movementInput.y;

    }
}
