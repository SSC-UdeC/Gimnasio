window.downloadFile = (filename, byteArray) => {
    const blob = new Blob([new Uint8Array(byteArray)], { type: "image/png" });
    const link = document.createElement("a");
    link.href = URL.createObjectURL(blob);
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
