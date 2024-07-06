using UnityEngine;

[RequireComponent(typeof(ColorChanger))]
public class Cube : BombSpawner
{
    private ColorChanger _colorChanger;

    public bool IsColorChanged => _colorChanger.IscolorChanged;

    private void Awake()
    {
        _colorChanger = GetComponent<ColorChanger>();
    }

    public void OnCollisionWithPlatform()
    {
        if (_colorChanger.IscolorChanged == false)
            _colorChanger.ChangeColor();
    }

    public void StartReturning()
    {
        _colorChanger.ResetColor();
    }
}
