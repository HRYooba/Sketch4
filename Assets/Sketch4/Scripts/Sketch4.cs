using UnityEngine;

public class Sketch4 : MonoBehaviour
{
    [SerializeField] private RenderTexture _webCameraTexture;
    private WebCamTexture _webCamTexture;

    [SerializeField] private RenderTexture _opticalFlowTexture;
    [SerializeField] private OpticalFlow.OpticalFlow _opticalFlow;

    private void Awake()
    {
        _webCamTexture = new();
    }

    private void Start()
    {
        _webCamTexture.Play();
    }

    private void Update()
    {
        Graphics.Blit(_webCamTexture, _webCameraTexture);
        _opticalFlow.Calculate(_webCameraTexture);
        Graphics.Blit(_opticalFlow.Flow, _opticalFlowTexture);
    }
}
