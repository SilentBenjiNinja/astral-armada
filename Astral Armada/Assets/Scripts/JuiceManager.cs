using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceManager : MonoBehaviour
{
    public GameObject aa1Prefab;

    public void OnAA1Kill(Vector3 pos)
    {
        Instantiate(aa1Prefab, pos, Quaternion.identity, this.transform);

        StopAllCoroutines();
        StartCoroutine(EpicCoroutine());
    }

    IEnumerator EpicCoroutine()
    {
        Time.timeScale = 0.25f;
        yield return new WaitForSecondsRealtime(0.1f);
        Time.timeScale = 1;

        float rumbleTime = 0.3f;
        float timer = rumbleTime;

        Camera.main.transform.position = new Vector3(0, 0, -10);
        while (timer > 0)
        {
            float randomX = Random.Range(-0.15f, 0.15f) * (timer / rumbleTime);
            float randomY = Random.Range(-0.15f, 0.15f) * (timer / rumbleTime);
            Camera.main.transform.position = new Vector3(randomX, randomY, -10);
            yield return new WaitForEndOfFrame();
            timer -= Time.deltaTime;
        }

        Camera.main.transform.position = new Vector3(0, 0, -10);
    }
}
