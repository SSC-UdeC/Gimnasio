console.log("qrScanner.js cargado");
window.startQRScanner = () => {
    const video = document.getElementById('video');
    if (!video) {
        console.error("No se encontró el elemento de video.");
        return;
    }

    const constraints = { video: { facingMode: 'environment' } };

    navigator.mediaDevices.getUserMedia(constraints)
        .then((stream) => {
            console.log("Cámara activada con éxito.");
            video.srcObject = stream;
        })
        .catch((err) => {
            console.error("Error al acceder a la cámara:", err);
        });
};

alert("qrScanner.js cargado");

