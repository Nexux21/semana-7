using UnityEngine;

public class SlowAbility : BaseAbility
{
    public override void Execute()
    {
        PlayFeedback();
        Shoot(6f, StatusEffecf.Slow, 4f);
    }
}