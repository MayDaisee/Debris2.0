using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject cubePrefab;
    public int cubeDensity;
    public int seed;
    public float innerRadius;
    public float outerRadius;
    public float height;
    public bool rotatingClockwise;

    [Header("Asteroid Settings")]
    public float minOrbitSpeed;
    public float maxOrbitSpeed;

    private Vector3 localPosition;
    private Vector3 worldOffset;
    private Vector3 worldPosition;
    private float randomRadius;
    private float randomRadian;
    private float x;
    private float y;
    private float z;

    //================================================
    // Random Point on a Circle given only the Angle.
    // x = cx + r * cos(a)
    // y = cy + r* sin(a)
    //================================================
    private void Start()
    {
        Random.InitState(seed);

        for (int i = 0; i < cubeDensity; i++)
        {
            do
            {
                randomRadius = Random.Range(innerRadius, outerRadius);
                randomRadian = Random.Range(0, (2 * Mathf.PI));

                y = Random.Range(-(height / 1), (height / 1));
                x = randomRadius * Mathf.Cos(randomRadian);
                z = randomRadius * Mathf.Sin(randomRadian);
            }
            while (float.IsNaN(z) && float.IsNaN(x));

            localPosition = new Vector3(x, y, z);
            worldOffset = transform.rotation * localPosition;
            worldPosition = transform.position + worldOffset;

            GameObject _asteroids = Instantiate(cubePrefab, worldPosition, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            RandomRotator[] components = _asteroids.GetComponentsInChildren<RandomRotator>();
            foreach (var item in components)
            {
                item.tumble = Random.Range(minOrbitSpeed, maxOrbitSpeed);
            }
           
            _asteroids.transform.SetParent(transform);
        }
    }
}
