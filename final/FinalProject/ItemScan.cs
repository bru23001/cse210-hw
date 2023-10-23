/*
This class will scan the item barcodes will a phone camera. Properties: BarcodeNumber, IsValid. 
Methods: 1. ScanBarcode(), 2. Validation().

*/

public class ItemScan 
{ 
    public string BarcodeNumber {get; set;}
    public bool IsValid { get; set; }
    
    public void ScanItem()
    {
    }

    public string ScanBarcode()
    {
        Console.WriteLine("Please scan the item barcode:");
        string barcode = Console.ReadLine();
        return barcode;
    }

    public void Validation()
    {
        // barcode validation logic
    }
}