let video;
let qrScanner;
let canvasElement, canvas;

window.startQRScanner = () => {
    video = document.getElementById("video");
    canvasElement = document.createElement("canvas");
    canvas = canvasElement.getContext("2d");

    navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment" } })
        .then((stream) => {
            video.srcObject = stream;
            video.setAttribute("playsinline", true); // Necesario para que funcione en iOS
            video.play();
            requestAnimationFrame(tick);
        })
        .catch(err => console.error("Error al acceder a la cámara: ", err));
};

function tick() {
    if (video.readyState === video.HAVE_ENOUGH_DATA) {
        canvasElement.height = video.videoHeight;
        canvasElement.width = video.videoWidth;
        canvas.drawImage(video, 0, 0, canvasElement.width, canvasElement.height);
        const imageData = canvas.getImageData(0, 0, canvasElement.width, canvasElement.height);

        const code = jsQR(imageData.data, imageData.width, imageData.height);
        if (code) {
            DotNet.invokeMethodAsync("TuAppNamespace", "OnQRCodeScanned", code.data);
        }
    }
    requestAnimationFrame(tick);
}
