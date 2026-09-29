using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public BaseAbility[] abilities;

    private InputSystem_Actions inputs;

    private BaseAbility current; 

    private void Awake()
    {
        inputs = new();

    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Ability1.performed += SelecAbilitty1;
        inputs.Player.Ability2.performed += SelecAbilitty2;
        inputs.Player.Ability3.performed += SelecAbilitty3;
        inputs.Player.Ability4.performed += SelecAbilitty4;
        inputs.Player.Ability5.performed += SelecAbilitty5;

        inputs.Player.Attack.performed += OnCast;
    }
    private void OnCast(InputAction.CallbackContext context)
    {
        if (current == null) return;

        current.Execute();
        current = null; 
    }

    private void SelecAbilitty5(InputAction.CallbackContext context)
    {
        Select(4);
    }

    private void SelecAbilitty4(InputAction.CallbackContext context)
    {
        Select(3);
    }

    private void SelecAbilitty3(InputAction.CallbackContext context)
    {
        Select(2);
    }

    private void SelecAbilitty2(InputAction.CallbackContext context)
    {
        Select(1);
    }

    private void SelecAbilitty1(InputAction.CallbackContext context)
    {
        Select(0);

    }

    private void OnDisable()
    {
        
    }

    public void Select(int index)
    {
        current = abilities[index]; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
