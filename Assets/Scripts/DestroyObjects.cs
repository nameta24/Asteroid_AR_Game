using UnityEngine;
using UnityEngine.Events;

public class DestroyObjects : MonoBehaviour
{
    [SerializeField] private float _destroyDelay = 0.1f;
    [SerializeField] private UnityEvent OnDestroy;

    public void DestroyWithDelay()
    {
        Debug.Log($"{gameObject.name} destroyed");

        /// <summary>
        /// OnDestroy?.Invoke();: This line executes the UnityEvent named OnDestroy.
        /// </summary>
        OnDestroy?.Invoke();

        Destroy(gameObject, _destroyDelay);
    }
}