using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public NuvensScript prefab;
    public float intervaloTempo = 1f;
    public float alturaMax = -2f;
    public float alturaMin = 2f;
    public float espacoCano = 2f;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), intervaloTempo, intervaloTempo);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        NuvensScript cano = Instantiate(prefab,prefab.transform.position, Quaternion.identity);
        cano.transform.position += Vector3.up * Random.Range(alturaMin, alturaMax);

    }
}
  
