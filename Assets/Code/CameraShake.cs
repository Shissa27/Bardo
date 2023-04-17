using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originPos = transform.position;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = originPos.x + Random.Range(-1f, 1f) * magnitude;
            float y = originPos.y + Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(x, y, originPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.position = originPos;
    }
}
