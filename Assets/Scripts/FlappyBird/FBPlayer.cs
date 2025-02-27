using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBPlayer : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody;

    public float flapForce = 6f; //점프 힘
    public float forwardSpeed = 3f; // 이동 속도
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    public bool godMode = false;

    FBGameManager FBgameManager;

    private void Start()
    {
        FBgameManager = FBGameManager.Instace;

        animator = GetComponentInChildren<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();

        if(animator == null)
        {
            Debug.LogError("Not Founded Animator");
        }
        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }

    private void Update()
    {
        if (isDead)
        {
            if (deathCooldown <= 0)
            {
                //게임 재시작
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FBgameManager.RestartGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                isFlap = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }

        _rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode) return;

        if (isDead) return;

        isDead = true;
        deathCooldown = 1f;

        animator.SetInteger("IsDie",1);
        FBgameManager.GameOver();
    }
}
