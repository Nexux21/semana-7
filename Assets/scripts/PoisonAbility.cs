using UnityEngine;

public class PoisonAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(10f, StatusEffect.Posion, 5f);
    }
}