using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;
    public Animator animator;

    public BaseAbility[] abilities;

    private InputSystem_Actions inputs;
    private BaseAbility current;

    private void Awake()
    {
        inputs = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    void Start()
    {
        if (abilities != null && abilities.Length > 0)
        {
            current = abilities[0];
        }
    }

    public void Select(int index)
    {
        if (abilities != null && index >= 0 && index < abilities.Length)
        {
            if (abilities[index] != null)
            {
                current = abilities[index];
                Debug.Log("Habilidad seleccionada: " + current.GetType().Name);
            }
        }
    }

    void Update()
    {
        
        moveInput = inputs.Player.Move.ReadValue<Vector2>();
        transform.position += (Vector3)moveInput * moveSpeed * Time.deltaTime;

        if (animator != null)
        {
            animator.SetFloat("movement", moveInput.x);
        }

        if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        
        if (inputs.Player.Ability1.WasPressedThisFrame()) Select(0);
        if (inputs.Player.Ability2.WasPressedThisFrame()) Select(1);
        if (inputs.Player.Ability3.WasPressedThisFrame()) Select(2);
        if (inputs.Player.Ability4.WasPressedThisFrame()) Select(3);
        if (inputs.Player.Ability5.WasPressedThisFrame()) Select(4);

        
        if (inputs.Player.Attack.WasPressedThisFrame())
        {
            if (current != null)
            {
                current.Execute();
            }
            else
            {
                Debug.LogWarning("No hay habilidad seleccionada.");
            }
        }
    }
}