window.generatePdfFromHtml = function (elementId) {
    console.log("generatePdfFromHtml called with elementId:", elementId);  

    const element = document.querySelector(elementId);
    if (element) {
        html2canvas(element, {
            backgroundColor: "white", 
        }).then(function (canvas) {
            console.log("Canvas generated");  
            const jsPDF = window.jspdf.jsPDF;

            if (!jsPDF) {
                console.error("jsPDF is not loaded properly");
                return;
            }
            const doc = new jsPDF('p', 'mm', 'a4');
            const canvasWidth = canvas.width;
            const canvasHeight = canvas.height;
            const pageWidth = doc.internal.pageSize.getWidth();
            const pageHeight = doc.internal.pageSize.getHeight();
            const margin = 10; 
            const maxWidth = pageWidth - 2 * margin;
            const scaleX = maxWidth / canvasWidth;
            const scaleY = pageHeight / canvasHeight;
            const scale = Math.min(scaleX, scaleY);  
            doc.addImage(canvas.toDataURL("image/png"), "PNG", margin, margin, canvasWidth * scale, canvasHeight * scale);
            doc.save("generated-report.pdf");
        }).catch(function (error) {
            console.error("Error generating canvas:", error);
        });
    } else {
        console.error("Element not found:", elementId);
    }
};
