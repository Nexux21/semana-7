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
        if (castFeedback != null)
        {
            castFeedback.PlayFeedbacks();
        }
    }

    protected void Shoot(float speed, StatusEffect effect, float duration)
    {
        if (projectilePrefab == null || firePoint == null)return;
        

            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Projectile proj = projectile.GetComponent<Projectile>();

        if (proj != null)
        {
            proj.speed = speed;
            proj.effect = effect;
            proj.duration = duration;
        }
    }
}