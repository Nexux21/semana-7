using UnityEngine;

public class FireAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(12f, StatusEffect.Burn, 3f);
    }
}