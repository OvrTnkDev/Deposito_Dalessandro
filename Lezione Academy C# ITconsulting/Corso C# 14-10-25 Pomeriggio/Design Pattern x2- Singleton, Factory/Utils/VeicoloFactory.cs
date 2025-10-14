namespace Utils
{
    public static class VeicoloFactory
    {
        public static IVeicolo CreaVeicolo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "auto":
                    return new Auto();
                case "moto":
                    return new Moto();
                case "camion":
                    return new Camion();
                default:
                    return null;
            }
        }
    }
}
