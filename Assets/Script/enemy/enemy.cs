using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : Entity
{

    // Start is called before the first frame update
    private void Awake()
    {
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        moving();
    }

    public override void moving()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            this.gameObject.transform.LookAt(player.transform.position);
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
