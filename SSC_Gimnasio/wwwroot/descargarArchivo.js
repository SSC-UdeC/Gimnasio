window.descargarArchivoQr = (fileName, byteArray) => {
    const blob = new Blob([new Uint8Array(byteArray)], { type: "image/png" });
    const link = document.createElement("a");
    link.href = URL.createObjectURL(blob);
    link.download = fileName;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};

window.descargarArchivoPdf = (filename, mimeType, base64Data) => {
    const link = document.createElement("a");
    link.href = `data:${mimeType};base64,${base64Data}`;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
