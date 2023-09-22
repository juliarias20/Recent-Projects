using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform enemy;
    public Transform player;
    public Transform target;

    public List<Transform> points;
    public int nextID;
    private int idChangeValue = 1;
    public float speed;

    
    public Transform start;
    public Transform end;

    public float withinRange = 10;


    // Start is called before the first frame update
    void Start()
    {

 


        
    }


    private void MovetoNextPoint()
    {
        Transform goalPoint = points[nextID];

        if(goalPoint.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, goalPoint.transform.position) < 1f)
        {
            if(nextID == points.Count - 1)
            {
                idChangeValue = -1;
            }

            if(nextID == 0)
            {
                idChangeValue = 1;
            }

            nextID += idChangeValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.transform.position) < 1)
        {
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            MovetoNextPoint();
        }
    }
}
