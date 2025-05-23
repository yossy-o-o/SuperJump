using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

    [SerializeField] LayerMask groundLayer;
    [SerializeField] AudioClip jumpClip;
    [SerializeField] AudioSource audioSourceJump; // ジャンプ音用のAudioSource

    AudioSource audioSource;
    public float jumpForce = 2.0f; // 基本のジャンプ力
    public float jumpTime = 0.5f; // ジャンプ力が最大になるまでの時間
    public SpriteRenderer spriteRenderer; // プレイヤーのSpriteRenderer

    private bool isJumping = false;
    private float jumpTimeCounter;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // SpriteRendererを取得
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = jumpClip;
    }

    void Update()
    {
        bool isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 5.0f, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)//Spaceを押したかつ、地面についているとき、
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            spriteRenderer.color = Color.red; // 色を赤に変更
            rb.velocity = Vector2.zero; // プレイヤーの動きを止める
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            if (isJumping == true)
            {
                // ジャンプ力を時間に比例させる
                float proportionalJumpForce = jumpForce * (jumpTime - jumpTimeCounter) / jumpTime;
                rb.velocity = Vector2.up * proportionalJumpForce; // ジャンプする
                spriteRenderer.color = Color.blue;
                audioSourceJump.Play();
            }
            isJumping = false;
            spriteRenderer.color = Color.white; // 色を元に戻す
        }
        
    }


}