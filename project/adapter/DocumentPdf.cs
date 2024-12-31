using System;
public class DocumentPdf : IDocument
{

 public void SetContenu(string contenu) {
        _contenu = contenu;
        _outilPdf.PdfFixeContenu(contenu);
    }

    public void Dessine() {
        _outilPdf.PdfPrepareAffichage();
        _outilPdf.PdfRafraichit();
        _outilPdf.PdfTermineAffichage();
    }

    public void Imprime() {
        _outilPdf.PdfEnvoieImprimante();
    }

}