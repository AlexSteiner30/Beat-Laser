using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject laser;
    public GameManager gameManager;

    public float spawnRate;
    public float speed = 0.01f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (gameManager.alive)
        {
            SpawnLaser(speed);
            yield return new WaitForSecondsRealtime(spawnRate);
        }
    }

    public void SpawnLaser(float speed)
    {
        GameObject spawnedLaser = Instantiate(laser, new Vector3(0, Random.Range(1f, 4.5f), 16), Quaternion.identity);

        spawnedLaser.GetComponent<Laser>().speed = speed;
        spawnedLaser.transform.rotation = Quaternion.Euler(0f, 90f, 0);
    }
}
