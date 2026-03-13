using DG.Tweening;
using UnityEngine;

public class ChestInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Ease ease;

    [SerializeField] private Transform chestLid;
    [SerializeField] private Vector3 chestLidRotation;
    [SerializeField] private float chestLidDuration;
    
    private Tween _collectTween;
   private Tween _openLidTween;
    private Tween _loopTween;
    private int isOpenHash;

    private void Start()
    {

        _loopTween = transform.DOScale(1.6f, .2f).SetLoops(-1, LoopType.Yoyo).SetEase(ease)
            .SetDelay(Random.Range(0.5f, 2.5f));
    }

    private void OnDestroy()
    {
        DOTween.Kill(gameObject);
    }

    public void OnHoverIn()
    {
        Debug.Log("Interact in!");
        
        //open chest
        chestLid.DOLocalRotate(chestLidRotation, chestLidDuration).SetEase(ease);

        Toast.Instance.ShowToast("Press \"E\" to Interact");
    }

    public void OnHoverOut()
    {
        //close chest
      chestLid.DOLocalRotate(Vector3.zero, chestLidDuration).SetEase(ease);
        Debug.Log("Interact out!");

        Toast.Instance.HideToast();
    }

    public void OnInteract()
    {
        Debug.Log($"Interacted with {gameObject.name}");

        _collectTween = transform.DOScale(0, .5f).SetEase(Ease.InBack).OnComplete(() => { Destroy(gameObject); });
    }
}