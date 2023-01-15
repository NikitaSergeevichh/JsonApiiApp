namespace JSONApiApp.Service
{
    public class ServiceConvertDistance
    {
        public double UnitOutput { get; set; }
        public double UnitInput { get; set; }        
        public void ToMeter(string NameUnit, double number)
        {
            switch (NameUnit)
            {
                case "M":
                    UnitInput = number * 1;
                    break;
                case "Km":
                    UnitInput = number * 1000;
                    break;
                case "Mm":
                    UnitInput = number / 1000;
                    break;
                case "Cm":
                    UnitInput = number / 100;
                    break;
                case "Yard":
                    UnitInput = number * 1.093;
                    break;
                case "lb.":
                    UnitInput = number * 3.280;
                    break;
                default:
                    break;
            }
        }
        public double GetConverter(string UnitNameOutput)
        {
            switch (UnitNameOutput)
            {
                case "M":
                    return UnitInput * 1;
                    break;
                case "Km":
                    return UnitInput / 1000;
                    break;
                case "Mm":
                    return UnitInput * 1000;
                    break;
                case "Cm":
                    return UnitInput * 100;
                    break;
                case "Yard":
                    return UnitInput / 1.09361;
                    break;
                case "lb.":
                    return UnitInput / 3.28084;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
