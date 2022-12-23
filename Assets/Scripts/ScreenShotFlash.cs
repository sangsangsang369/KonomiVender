
using UnityEngine;
using UnityEngine.UI;

public class ScreenShotFlash : MonoBehaviour
{
    public float duration = 0.3f;

    public Image _image;
    private float _currentAlpha = 1f;


    private void Update()
    {
        Color col = _image.color;
        col.a = _currentAlpha;
        _image.color = col;

        _currentAlpha -= Time.unscaledDeltaTime / duration;

        if (_currentAlpha < 0f)
            gameObject.SetActive(false);
    }

    public void Show()
    {
        _currentAlpha = 1f;
        gameObject.SetActive(true);
    }
}
