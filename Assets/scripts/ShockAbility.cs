using UnityEngine;

public class ShockAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(15f, StatusEffecf.Shock, 2f);
    }

    protected override void PlayFeedback()
    {
        base.PlayFeedback(); // Llama al feedback base del Hito 3
        Debug.Log("Lanzando partículas / efectos extras de Rayo...");
    }
}