using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private TextMeshProUGUI _textOchko;
    [SerializeField] private TextMeshProUGUI _textLive;
    [SerializeField] private int _live;

    [SerializeField] private UIMANAGER _uiManager;

    private AudioSource _audioSource;

    private bool _immortal = true;


    private int _ochko;

    private int x;
    private int y;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            x = 0;
            y = 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            x = 0;
            y = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            x = -1;
            y = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            x = 1;
            y = 0;
        }
        transform.position += new Vector3(x, y, 0) * _speed * Time.deltaTime;

    }

    private void OnImortal()
    {
        _immortal = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>() && _immortal)
        {
            _immortal = false;
            _live -= 1;
            _textLive.text = _live.ToString();
            _audioSource.Play();
            _audioSource.volume = Nastroika.ZvukVoice;
            if (_live <= 0)
            {
                _uiManager.NewSlide(0);
                Destroy(gameObject);
            }
            Invoke(nameof(OnImortal),3);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ochko>())
        {
            _ochko++;
            _textOchko.text = _ochko.ToString();
            if (_ochko >= 128)
            {
                _uiManager.NewSlide(1);
                Time.timeScale = 0;
            }
            Destroy(collision.gameObject);
        }
    }
}
