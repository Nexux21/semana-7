using UnityEngine;

public class PoisonAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(10f, StatusEffecf.Posion, 5f);
    }
}