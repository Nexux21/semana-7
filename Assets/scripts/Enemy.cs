using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyStatus(StatusEffecf effecf)
    {
        Debug.Log("Enemigo recibe:" +  effecf);
    }

    public void ApplyStatus(StatusEffecf effecf, float duration)

    {
        Debug.Log("Enemigo recibe:" + effecf + "Time:" +  duration);
    }
}
