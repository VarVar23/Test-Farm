using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public float R;
    public int count;
    public Image Img;
    public Transform Parent;

    public Transform Test2;

    private void Start()
    {
        StartCoroutine(SSS());
    }

    private IEnumerator SSS()
    {
        int i = 1;
        int angle = 360 / count;

        while(i <= count)
        {
            var o = Instantiate(Img, Parent);
            var t = o.GetComponent<Transform>();

            t.Rotate(new Vector3(0, 0, i * angle));
            yield return new WaitForSeconds(0.1f);
            t.localPosition = t.up * R;
            yield return new WaitForSeconds(0.1f);
            t.rotation = Quaternion.identity;

            i++;
        }



    }
}
