using UnityEngine;

public class Platform : CubeReseter
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Cube cube))
            ReturnCube(cube);
    }
}