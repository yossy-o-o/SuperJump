using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public int rightSpeed;
    public int leftSpeed;


    public int getPotionRightSpeed = 6; // Rightポーション速度
    public int getPotionLeftSpeed = -6; // Leftポーション速度
    private int previousRightSpeed = 3; //Rightポーション後元の速度
    private int previousLeftSpeed = -3; //Leftポーション後元の速度

    [SerializeField] GameObject resultPanel;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI goalTimeText;

    [SerializeField] List<GameObject> coins;
    [SerializeField] TextMeshProUGUI howCoinText;
    [SerializeField] TextMeshProUGUI CoinText;
    [SerializeField] TextMeshProUGUI MainAssessmentText;
    [SerializeField] GameObject StartButton;
    [SerializeField] GameObject EndTutorialPanel;
    [SerializeField] GameObject ClearTutorialPanel;

    [SerializeField] GameObject TutorialClearPanel;
    [SerializeField] AudioClip startMusicAriaClip;
    [SerializeField] AudioClip CoinClip;
    [SerializeField] AudioSource CoinSorce;

    [SerializeField] AudioClip ForestMusicClip;
    [SerializeField] AudioClip ForestMusicClip2;
    [SerializeField] AudioClip ForestMusicClip3;
    [SerializeField] AudioClip ForestMusicClip4;

    [SerializeField] AudioSource audioSourceCoin;
    [SerializeField] AudioSource audioSourceAriamusic;
    [SerializeField] AudioSource ForestMusicSource;
    [SerializeField] AudioSource ForestMusicSource2;
    [SerializeField] AudioSource ForestMusicSource3;
    [SerializeField] AudioSource ForestMusicSource4;

    [SerializeField] AudioClip FristMusicClip;
    [SerializeField] AudioSource FristAudioSorce;
    [SerializeField] AudioClip inForestBgm;
    [SerializeField] AudioSource inForestsorce;

    [SerializeField] AudioClip IceFieldClip;
    [SerializeField] AudioSource IcefieldSorce;

    [SerializeField] AudioClip FireClip;
    [SerializeField] AudioSource FireSorce;

    [SerializeField] AudioClip LastClip;
    [SerializeField] AudioSource LastSorce;
    
    AudioSource audioSource;
     AudioSource StartMudicAriasorce;
     AudioSource CoinClipsorce;

     float countTime = 0;

     private int CoinScore = 0;

    public bool isTimerActive = true;   //Time.timescale混同しないためにboolで判断
    
    //列挙型で使うであろう変数を挙げる
    public enum DIRECTION_TYPE
    {
        STOP,
        RIGHT,
        LEFT
    }

    DIRECTION_TYPE direction = DIRECTION_TYPE.STOP;

    Rigidbody2D rb; //rigidbody2Dをrbに

    Animator anim; //animatorをanimに

    float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //audioSourceCoin = gameObject.AddComponent<AudioSource>();
        //audioSourceCoin.clip = CoinClip;

        audioSourceAriamusic = gameObject.AddComponent<AudioSource>();
        audioSourceAriamusic.clip = startMusicAriaClip;


         /*ForestMusicSource = GetComponent<AudioSource>();
         ForestMusicSource.clip = ForestMusicClip;

         ForestMusicSource2 = GetComponent<AudioSource>();
         ForestMusicSource2.clip = ForestMusicClip2;

         ForestMusicSource3 = GetComponent<AudioSource>();
         ForestMusicSource3.clip = ForestMusicClip3;

         ForestMusicSource4 = GetComponent<AudioSource>();
         ForestMusicSource3.clip = ForestMusicClip3;*/

    }
    
    void Update()
    {
        Move();
        ShowResult();
        TimerFlag();
    }
    
    //列挙型で挙げた変数をもとにPlayerの動きを処理
    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        
        //止まっている
        if(x == 0)
        {
            direction = DIRECTION_TYPE.STOP;
        }
        //右へ移動
        else if(x > 0)
        {
            direction = DIRECTION_TYPE.RIGHT;
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetTrigger("Run");
        }
        //左へ移動
        else if (x < 0)
        {
            direction = DIRECTION_TYPE.LEFT;
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetTrigger("Run");
        }
    }

    //左右のスピード処理
    private void FixedUpdate() 
    {
        switch(direction)
        {
            case DIRECTION_TYPE.STOP:
            speed = 0;
            break;

            case DIRECTION_TYPE.RIGHT:
            speed = rightSpeed;
            break;

            case DIRECTION_TYPE.LEFT:
            speed = leftSpeed;
            break;
        }
        rb.velocity = new Vector2(speed,rb.velocity.y);
    }

    //triggerでTagを検知するための処理
    public void OnTriggerEnter2D(Collider2D other)
    {
        //SpeedUpPotionの処理
        if(other.gameObject.CompareTag("Potion"))
        {
            // ポーション効果を適用
            rightSpeed = getPotionRightSpeed;
            leftSpeed = getPotionLeftSpeed;

            // ポーションを破壊
            Destroy(other.gameObject); 

            // ポーション効果を解除するためのコルーチンを開始
            StartCoroutine(ResetSpeedAfterPotionEffect());
        }
        //StopTimerItemの処理
        else if (other.gameObject.CompareTag("StopTimerItem"))
        {
            StopTimerItemEffect();
            Destroy(other.gameObject); 
        }

        //ゴールNpcに触れたらの処理
        if(other.gameObject.CompareTag("GoalNpc"))
        {
            resultPanel.SetActive(true);
            isTimerActive = false;
            StopGame();
        }

        //コインの処理
        if(other.gameObject.CompareTag("Coin"))
        {
            CoinSorce.Play();
            CoinScore += 1;
            CoinText.text = CoinScore.ToString();
            Destroy(other.gameObject);
        }

        //スタート画面処理
        if(other.gameObject.CompareTag("StartButtonZone"))
        {
            StartButton.SetActive(true);
        }
        
        //Tutorial1Npc処理
        if(other.gameObject.CompareTag("Tutorial1Npc"))
        {
           ClearTutorialPanel.SetActive(true);
        }

        //Tutorial2Npcの処理
        if(other.gameObject.CompareTag("Tutorial2Npc"))
        {
           TutorialClearPanel.SetActive(true);
           Time.timeScale = 0;
        }

        //音を流す場所の処理
        if(other.gameObject.CompareTag("StartMusicAria"))
        {
           audioSourceAriamusic.Play();
           FireSorce.Stop();
        }

        if(other.gameObject.CompareTag("ForestAriaMisic"))
        {
            
            ForestMusicSource.Play();
            ForestMusicSource2.Play();
            ForestMusicSource3.Play();
            ForestMusicSource4.Play();
            FristAudioSorce.Stop();
            inForestsorce.Stop();
            IcefieldSorce.Stop();
            FireSorce.Stop();
            LastSorce.Stop();
        }

        if(other.gameObject.CompareTag("EndMusicaria"))
        {
            ForestMusicSource.Stop();
            ForestMusicSource2.Stop();
            ForestMusicSource3.Stop();
            ForestMusicSource4.Stop();
            inForestsorce.Stop();
            IcefieldSorce.Stop();
            FireSorce.Stop();
            LastSorce.Stop();
        }

        if(other.gameObject.CompareTag("FristMusicAria"))
        {
            FristAudioSorce.Play();
            IcefieldSorce.Stop();
            FireSorce.Stop();
            LastSorce.Stop();
        }

        if(other.gameObject.CompareTag("shopEndAriaMusic"))
        {
            ForestMusicSource.Stop();
            ForestMusicSource2.Stop();
            ForestMusicSource3.Stop();
            ForestMusicSource4.Stop();
            inForestsorce.Play();
            IcefieldSorce.Stop();
            FireSorce.Stop();
            LastSorce.Stop();
        }

        if(other.gameObject.CompareTag("IceFieldMusic"))
        {
            inForestsorce.Stop();
            IcefieldSorce.Play();
            FireSorce.Play();
            LastSorce.Stop();
        }

        if(other.gameObject.CompareTag("LastAriaMusic"))
        {
            IcefieldSorce.Stop();
            FireSorce.Stop();
            LastSorce.Play();
        }

    }

    //20秒間だけ効果を実装
    //スピードアップポーションの実装
    IEnumerator ResetSpeedAfterPotionEffect()
    {
            // 20秒間待機
        yield return new WaitForSeconds(20);

            // ポーション効果を解除（元の速度に戻す）
        rightSpeed = previousRightSpeed;
        leftSpeed = previousLeftSpeed;
    }


    //StopTimerItemの処理
    void StopTimerItemEffect()
    {
        //Mathf.Maxを使うことで0か-10した後の値がどっち大きいかを比較して、大きい方を返してくれる、
        countTime = Mathf.Max(0, countTime - 20);
    }
    
    void timer()
    {
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime += Time.deltaTime;
        // 小数2桁にして表示
        timerText.text = countTime.ToString("F2");
    }

    public void StopGame()
    {
        Time.timeScale = 0;
        Debug.Log("Stop");
    }

    public void ShowResult()
    {
        //ゴールした後の時間の処理
        goalTimeText.text = countTime.ToString("F2");
        //ゴール後のコインの処理
        howCoinText.text = CoinScore.ToString();

        // スコアの判定
        if (CoinScore >= 19 && countTime <= 130.0f)
        {
            MainAssessmentText.text = "S";
        }
        else if (CoinScore >= 15 && countTime <= 150.0f)
        {
            MainAssessmentText.text = "A";
        }
        else if (CoinScore >= 10 && countTime <= 180.0f)
        {
            MainAssessmentText.text = "B";
        }
        else
        {
            MainAssessmentText.text = "C";
        }
    }

    //timerのFlag処理
    void TimerFlag()
    {
        if(isTimerActive) // タイマーが動作中の場合のみ時間を加算
        {
            timer();
        }
    }

}
