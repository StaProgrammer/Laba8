public class PhoneFactory : TechProductFactory
{
    public override Display CreateDisplay()
    {
        return new PhoneDisplay();
    }

    public override Processor CreateProcessor()
    {
        return new PhoneProcessor();
    }

    public override Camera CreateCamera()
    {
        return new PhoneCamera();
    }
}
