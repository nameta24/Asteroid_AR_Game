using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class UFOAttack : MonoBehaviour
{

    [SerializeField] private float _fireCooldownTime = 0.3f;
    [SerializeField] private UnityEvent OnShoot;



    // This function is called when the object becomes enabled and active.
    private void OnEnable()
    {
        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        // continue loop while the UFOAttack component is enabled.
        while (enabled)
        {
            // trigger shooting event 
            OnShoot?.Invoke();

            // wait before looping again
            yield return new WaitForSeconds(_fireCooldownTime);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
