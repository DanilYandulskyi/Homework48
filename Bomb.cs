using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _force;

    public void ExplodeBomb()
    {
        StartCoroutine(Explode());
    }

    private IEnumerator Explode()
    {
        int minWaitTime = 2;
        int maxWaitTime = 5;

        yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));

        Destroy(gameObject);
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

        foreach (var collider in colliders)
        {
            if (collider.TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }
}