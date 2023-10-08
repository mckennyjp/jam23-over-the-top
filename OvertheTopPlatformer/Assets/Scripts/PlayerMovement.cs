using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public UnityEvent Won;
    public UnityEvent Lost;
    
    private float horizontal;
    [SerializeField] private float speed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float jetpackPower;

    [SerializeField] AudioSource jumpSound;
    [SerializeField] AudioSource jetpackSound;
    [SerializeField] AudioSource jetpackSound2;
    
    //[SerializeField] private Transform playerTransform;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private SpriteRenderer playerSprite;
    private Animator anim;
    private enum MovementState {idle, run, jump, fall};

    private void Start(){
        playerSprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal > 0){
            playerSprite.flipX = false;
        } else if (horizontal < 0){
            playerSprite.flipX = true;
        }

        if(Input.GetButtonDown("Jump") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            jumpSound.Play();
        }

        UpdateAnim();
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded(){
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "WinCondition"){
            Won.Invoke();
        } else if(col.tag == "Jetpack"){
            Jetpack();
            //Destroy(col,0f);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Crusher"){
            Lost.Invoke();
        }
    }

    private void Jetpack(){
        Debug.Log("Jetpack gotten");
        rb.velocity = new Vector2(rb.velocity.x, jetpackPower);
        jetpackSound.Play();
        jetpackSound2.Play();
    }

    private void UpdateAnim(){
        MovementState state;
        if(horizontal != 0){
            state = MovementState.run;
        } else{
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f){
            state = MovementState.jump;
        } else if(rb.velocity.y < -.1f){
            state = MovementState.fall;
        }
        anim.SetInteger("state", (int)state);
    }
}
