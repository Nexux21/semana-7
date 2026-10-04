using UnityEngine;

public class FireAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(12f, StatusEffecf.Burn, 3f);
    }
}