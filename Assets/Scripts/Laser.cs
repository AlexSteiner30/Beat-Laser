using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameManager gameManager;

    public Transform player;
    public float speed;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(gameManager.alive)
        {
            RayCastCheck();

            if (this.transform.position.z > player.transform.position.z - 2.5f)
                Move(speed);
            else
            {
                Destroy(this.gameObject);
                gameManager.score++;
                gameManager.scoreTxt.text = gameManager.score.ToString();
            }
        }
    }

    private void RayCastCheck()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if ((hit.collider.gameObject.tag == "Player"))
            {
                print("Game Over!");
                gameManager.GameOver();
            }

            print("Game Over!2");
        }
    }

    public void Move(float speed)
    {
        transform.position += new Vector3(0f, 0f, -1f * speed);
    }
}