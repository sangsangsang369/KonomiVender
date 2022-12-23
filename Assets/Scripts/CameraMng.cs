
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class CameraMng : MonoBehaviour
{
    WebCamTexture camTexture;
    public BtnMng btnMng;

    public RawImage cameraViewImage;

    public void CameraOn()
    {
        if(!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        if(WebCamTexture.devices.Length == 0)
        {
            Debug.Log("no camera");
            return;
        }

        WebCamDevice[] devices = WebCamTexture.devices;
        int selectedCamIndex = -1;

        for(int i = 0; i<devices.Length; i++)
        {
            if(devices[i].isFrontFacing == false)
            {
                selectedCamIndex = i;
                break;
            }            
        }

        if(selectedCamIndex >= 0)
        {
            camTexture = new WebCamTexture(devices[selectedCamIndex].name);

            camTexture.requestedFPS = 30;

            cameraViewImage.texture = camTexture;

            camTexture.Play();
        }

        cameraViewImage.gameObject.SetActive(true);
    }

    public void CameraOff()
    {
        btnMng.sound.clip = btnMng.drop;
        btnMng.sound.Play();
        if(camTexture != null)
        {
            camTexture.Stop();
            WebCamTexture.Destroy(camTexture);
            camTexture = null;
        }
        cameraViewImage.gameObject.SetActive(false);
    }
}
