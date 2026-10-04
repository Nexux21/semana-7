using UnityEngine;

public class IceAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(8f, StatusEffecf.Freeze, 4f);
    }

    protected override void PlayFeedback()
    {
        base.PlayFeedback(); // Llama al feedback base del Hito 3
        Debug.Log("Lanzando partículas / efectos extras de Hielo...");
    }
}