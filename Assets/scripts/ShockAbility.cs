using UnityEngine;

public class ShockAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(15f, StatusEffect.Shock, 2f);
    }

    protected override void PlayFeedback()
    {
        base.PlayFeedback(); 
        Debug.Log("Lanzando partículas / efectos extras de Rayo...");
    }
}