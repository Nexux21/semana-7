using UnityEngine;
using MoreMountains.Feedbacks;

public abstract class BaseAbility : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform firePoint;

    public MMF_Player castFeedback;

    public abstract void Execute();

protected virtual void PlayFeedback()
    {
        castFeedback.PlayFeedbacks();
    }

    protected void Shoot (float speed,StatusEffecf effect, float duration )
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    }
}

