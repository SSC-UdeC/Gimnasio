console.log("qrScanner.js cargado");
window.startQRScanner = () => {
    const video = document.getElementById('video');
    if (!video) {
        console.error("No se encontr� el elemento de video.");
        return;
    }

    const constraints = { video: { facingMode: 'environment' } };

    navigator.mediaDevices.getUserMedia(constraints)
        .then((stream) => {
            console.log("C�mara activada con �xito.");
            video.srcObject = stream;
        })
        .catch((err) => {
            console.error("Error al acceder a la c�mara:", err);
        });
};

alert("qrScanner.js cargado");

