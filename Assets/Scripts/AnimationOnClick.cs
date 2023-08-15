using UnityEngine;
using DG.Tweening;

public class AnimationOnClick : MonoBehaviour
{
    [SerializeField] private GameObject sceneButton;
    
    private int _jumpNumFlip = 1;
    private float _jumpDuraction = 1f;
    private float _jumpPower = 1f;
    
    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sceneButton.SetActive(false);
    }
    private void OnMouseUpAsButton()
    {
        Animation();
    }

    private void Animation()
    {
        boxCollider.enabled = false;
        transform.DOJump(transform.localPosition, _jumpPower, _jumpNumFlip, _jumpDuraction).OnComplete(() =>
        {
            boxCollider.enabled = true;
            sceneButton.SetActive(true);
        });;
    }

}
