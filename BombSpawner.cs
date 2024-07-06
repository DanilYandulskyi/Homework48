using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private Bomb _bomb;

    public void SpawnBomb()
    {
        Instantiate(_bomb, transform.position, Quaternion.identity).ExplodeBomb();
    }
}
