public class LaptopFactory : TechProductFactory
{
    public override Display CreateDisplay()
    {
        return new LaptopDisplay();
    }

    public override Processor CreateProcessor()
    {
        return new LaptopProcessor();
    }

    public override Camera CreateCamera()
    {
        return new LaptopCamera();
    }
}
