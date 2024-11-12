let video = document.getElementById("video");

async function startCamera() {
    if (navigator.mediaDevices && navigator.mediaDevices.getUserMedia) {
        navigator.mediaDevices.getUserMedia({ video: true })
            .then((stream) => {
                video.srcObject = stream;
                video.play();
                scanQRCode();
            })
            .catch((err) => console.error("Error al acceder a la cámara: ", err));
    } else {
        console.log("La cámara no es compatible.");
    }
}

async function scanQRCode() {
    // Llama a ZXing o a otro sistema de escaneo de QR para analizar el video y decodificar el QR
    // Este paso generalmente implica el uso de bibliotecas de procesamiento de imagen en JavaScript.
    // Por simplicidad, aquí simulo la detección QR con un valor predefinido.
    let qrText = "Ejemplo: Datos Cliente"; // Esto sería el texto decodificado del QR
    DotNet.invokeMethodAsync("TuNombreDeProyecto", "ProcesarQR", qrText); // Invoca el método en Blazor con los datos del QR.
}
