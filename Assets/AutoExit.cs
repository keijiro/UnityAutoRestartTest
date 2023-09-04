using UnityEngine;
using UnityEngine.Diagnostics;

public sealed class AutoExit : MonoBehaviour
{
    [SerializeField] float _delay = 3;
    [SerializeField] float _crashRatio = 0.5f;

    async void Start()
    {
        var cam = Camera.main;
        var t = 0.0f;

        while (t < 1.0f)
        {
            t += Time.deltaTime / _delay;
            cam.backgroundColor = Color.white * t;
            await Awaitable.NextFrameAsync();
        }

        if (Random.value < _crashRatio)
            Utils.ForceCrash(ForcedCrashCategory.FatalError);
        else
            Application.Quit(1);
    }
}
