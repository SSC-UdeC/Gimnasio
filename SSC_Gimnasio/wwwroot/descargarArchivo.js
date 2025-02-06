window.descargarArchivo = (fileName, byteArray) => {
    const blob = new Blob([new Uint8Array(byteArray)], { type: "image/png" });
    const link = document.createElement("a");
    link.href = URL.createObjectURL(blob);
    link.download = fileName;
    link.click();
};