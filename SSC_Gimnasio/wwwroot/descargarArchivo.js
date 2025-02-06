window.descargarArchivo = function (nombreArchivo, byteArray) {
    const blob = new Blob([byteArray], { type: "image/png" });
    const link = document.createElement('a');
    link.href = window.URL.createObjectURL(blob);
    link.download = nombreArchivo;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    window.URL.revokeObjectURL(link.href);
};