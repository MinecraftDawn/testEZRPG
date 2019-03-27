using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moving();
        roateing();
    }

    public override void moving()
    {
        //往前
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward *speed);
        }
        //往後
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back*speed);
        }
        //往左
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left*speed);
        }
        //往右
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right*speed);
        }
    }

    private void roateing()
    {
        //向左轉
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0f,2f,0f);
        }
        //向左轉
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0f,-2f,0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Entity otherEntity = other.gameObject.GetComponent<Entity>();
        if (otherEntity != null)
        {
            Damage(otherEntity.AttackPower);
        }
    }
}
