using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
   public static UserInput instance;

    public float MoveInputBack { get; private set; }
    public float MoveInputForward { get; private set; }
    public float MoveInputUp { get; private set; }
    public float MoveInputDown { get; private set; }
    public bool JumpTrigerred { get; private set; }
    public bool SprintInput { get; private set; }
    public bool UsingInput { get; private set; }
    public bool InteractionInput { get; private set; }
    public bool HintInput { get; private set; }
    public bool HintPressed { get; private set; }
    public bool MainMenuInput { get; private set; }
    public bool InventoryInput { get; private set; }
    public bool CatSpawnInput { get; private set; }


    private PlayerInput _playerInput;

    private InputAction _moveActionBack;
    private InputAction _moveActionForward;
    private InputAction _moveActionUp;
    private InputAction _moveActionDown;
    private InputAction _jumpAction;
    private InputAction _sprintAction;
    private InputAction _usingAction;
    private InputAction _interactionAction;
    private InputAction _hintAction;
    private InputAction _mainMenuAction;
    private InputAction _inventoryAction;
    private InputAction _catSpawnAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();

        SetupInputActions();
    }

    private void Update()
    {
        UpdateInputs();
    }

    private void SetupInputActions()
    {
        _moveActionBack = _playerInput.actions["Backward"];
        _moveActionForward = _playerInput.actions["Forward"];
        _moveActionUp = _playerInput.actions["Up"];
        _moveActionDown = _playerInput.actions["Down"];
        _jumpAction = _playerInput.actions["Jump"];
        _sprintAction = _playerInput.actions["Sprint"];
        _usingAction = _playerInput.actions["Using"];
        _interactionAction = _playerInput.actions["Interaction"];
        _hintAction = _playerInput.actions["Hint"];
        _mainMenuAction = _playerInput.actions["MainMenu"];
        _inventoryAction = _playerInput.actions["Inventory"];
        _catSpawnAction = _playerInput.actions["CatSpawn"];
    }

    private void UpdateInputs()
    {
        MoveInputBack = _moveActionBack.ReadValue<float>();
        MoveInputForward = _moveActionForward.ReadValue<float>();
        MoveInputUp = _moveActionUp.ReadValue<float>();
        MoveInputDown = _moveActionDown.ReadValue<float>();
        JumpTrigerred = _jumpAction.triggered;
        SprintInput = _sprintAction.IsPressed();
        UsingInput = _usingAction.triggered;
        InteractionInput = _interactionAction.triggered;
        HintPressed = _hintAction.WasPressedThisFrame();
        HintInput = _hintAction.IsPressed();
        MainMenuInput = _mainMenuAction.IsPressed();
        InventoryInput = _inventoryAction.triggered;
        CatSpawnInput = _catSpawnAction.triggered;

    }

}
