using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public TextMeshProUGUI count1;
    public TextMeshProUGUI count2;
    private int points1;
    private int points2;

    // Start is called before the first frame update
    void Start()
    {

        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        rb.velocity = new Vector3(x, 0, 5f);

        points1 = 0;
        points2 = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            points1++;
            count1.text = points1.ToString();
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            points2++;
            count2.text = points2.ToString();
        }
    }
}
