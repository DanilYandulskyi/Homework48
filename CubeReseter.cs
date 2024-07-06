using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CubeReseter : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoinsts;

    public void ReturnCube(Cube cube)
    {
        StartCoroutine(Return(cube));
    }

    private Vector3 GetNewPosition()
    {
        return _spawnPoinsts[Random.Range(0, _spawnPoinsts.Count)].position;
    }

    private IEnumerator Return(Cube cube)
    {
        if (cube.IsColorChanged == false)
        {
            cube.OnCollisionWithPlatform();
            int minWaitTime = 2;
            int maxWaitTime = 5;

            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));

            cube.SpawnBomb();
            cube.StartReturning();
            cube.transform.position = GetNewPosition();
        }
    }
}
