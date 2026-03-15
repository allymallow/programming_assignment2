using DG.Tweening;
using UnityEngine;

public class ChestInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Ease ease;

    [Header("Chest Opening/Close Settings")]
    [SerializeField] private Transform chestLid;
    [SerializeField] private Vector3 chestLidRotation;
    [SerializeField] private float chestLidDuration;
    
    private Tween _collectTween;
   private Tween _openLidTween;
    private Tween _loopTween;
    private int isOpenHash;

    private void Start()
    {
        //Chest pulse animation
        _loopTween = transform.DOScale(1.6f, .2f).SetLoops(-1, LoopType.Yoyo).SetEase(ease)
            .SetDelay(Random.Range(0.5f, 2.5f));
    }

    private void OnDestroy()
    {
        //kill Tween once object destroyed
        DOTween.Kill(gameObject);
    }

    public void OnHoverIn()
    { 
        //open chest via DOTween
        chestLid.DOLocalRotate(chestLidRotation, chestLidDuration).SetEase(ease);

        //enable toast text when player close
        Toast.Instance.ShowToast("Press \"E\" to Interact"); 
    }

    public void OnHoverOut()
    {
        //close chest via DOTween
      chestLid.DOLocalRotate(Vector3.zero, chestLidDuration).SetEase(ease);

        //hide toast text when player moves away
        Toast.Instance.HideToast(); 
    }

    public void OnInteract()
    {
        //Change scale then destroy chest once interacted with
        _collectTween = transform.DOScale(0, .5f).SetEase(Ease.InBack).OnComplete(() => { Destroy(gameObject); });
    }
}