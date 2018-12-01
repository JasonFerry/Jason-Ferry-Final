using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("JaFe_PlayerController"))
        {

            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<JaFe_PlayerController>().health -= damage;
            Debug.Log(other.GetComponent<JaFe_PlayerController>().health);
            Destroy(gameObject);
        }

    }
}
